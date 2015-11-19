using System.Collections.Generic;
using System.IO;
using System.Net;

namespace FTP_3xc
{
    interface IFtpUtils
    {
        List<string> GetServerFiles();
        long DownloadFiles(string filename, string destinationPath);
    }
    public class FtpUtils : IFtpUtils
    {
        private readonly FtpCreditentials _creditentials;
        public FtpUtils(FtpCreditentials creditentials)
        {
            _creditentials = creditentials;
        }

        //This method is responsible to connect to the server
        private FtpWebRequest ConnectToFtpServer(string filename = "")
        {
            var request = (FtpWebRequest) WebRequest.Create(_creditentials.HostPath + filename);
            request.Credentials = new NetworkCredential(_creditentials.Login, _creditentials.Password);
            return request;
        }

        public List<string> GetServerFiles()
        {
            //Connecting to server
            var request = ConnectToFtpServer();
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            
            //Getting Response stream
            var response = (FtpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            
            //check for null from server response
            if (responseStream == null) return null;
            var stremReader = new StreamReader(responseStream);
            var result = new List<string>();
            
            //Create a List of existing files
            while (!stremReader.EndOfStream)
            {
                result.Add(stremReader.ReadLine());
            }

            stremReader.Close();
            response.Close();
            return result;
        }

        public long DownloadFiles(string filename, string destinationPath)
        {
            //connecting to server
            var request = ConnectToFtpServer(filename);
            
            //command to download the file
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            var response = (FtpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
          
            //check for null from server response
            if (responseStream == null)
            {
                response.Close();
                return 0;
            }
            
            var reader = new StreamReader(responseStream);
            //TODO
            var writer = new StreamWriter(destinationPath);
            //writer.Write(reader.ReadToEnd());
            
            writer.Close();
            reader.Close();
            var length = response.ContentLength;

            response.Close();
            return length;
        }
    }
}