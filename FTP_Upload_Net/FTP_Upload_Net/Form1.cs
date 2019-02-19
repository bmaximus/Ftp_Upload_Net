using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Upload_Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          #if DEBUG
             txtHostName.Text = @"ftp://0.0.0.0";
             txtLogin.Text = @"login";
             txtPassword.Text = @"";
          #endif
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {

            //Checking hostname 
            if (txtHostName.Text == ""||!txtHostName.Text.Contains("ftp")){MessageBox.Show(@"Please Insert Host Name or enter full host name. (ftp://...)");return;}
            var ftpFiles = new List<string>();
            try
            {
                //Init creditentials
                var ftpUtils = new FtpUtils(new FtpCreditentials(txtHostName.Text, txtLogin.Text, txtPassword.Text));
                //Init Connection with server and get all server files
                ftpFiles = ftpUtils.GetServerFiles();
                if (ftpFiles == null){MessageBox.Show(@"Could not get any response from server.. ");return; this.Close();}
               
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);

            }
            if (ftpFiles != null && ftpFiles.Count == 0){return;}
            chkLstFtpData.DataSource = ftpFiles;
        }

        public List<string> SelectedItemsFromFtp()
        {
            //Getting all selected items from ftp
            return !((List<string>)chkLstFtpData.DataSource).Any() ? new List<string>() : (from object itemChecked in chkLstFtpData.CheckedItems select itemChecked.ToString()).ToList();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var selectedItems = SelectedItemsFromFtp();
            if (selectedItems.Count <= 0) return;
            var newPathToSave = "";
            
            var sf = new SaveFileDialog();
            var result = sf.ShowDialog();
            
            if( result == DialogResult.OK ){newPathToSave = Path.GetDirectoryName(sf.FileName);}
            
            var ftpUtils = new FtpUtils(new FtpCreditentials(txtHostName.Text, txtLogin.Text, txtPassword.Text));
            
            prgDownload.Step = 100/(selectedItems.Count);
            long lengthAccumulator = 0;
            foreach (var ftpFile in selectedItems)
            {
              prgDownload.PerformStep();
              lengthAccumulator +=   ftpUtils.DownloadFiles(("/"+ftpFile), newPathToSave);
              txtDownloadedBytes.Text = lengthAccumulator.ToString();
            }
        
        
        }
    }
}
