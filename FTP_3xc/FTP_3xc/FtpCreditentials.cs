using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP_3xc
{
    public class FtpCreditentials
    {
        //Constructor to ensure that host, login and password, will always have always values
        public FtpCreditentials(string host, string login, string password)
        {
            HostPath = host;
                        Login = login;
            Password = password;
        }
        public string HostPath { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
