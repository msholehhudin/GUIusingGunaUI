using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOA_s_Project
{
    class userAtt
    {
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string NIK { get; set; }
        public string pass { get; set; }


        public userAtt(string email, string fullname, string username, string nik, string password)
        {
            email = Email;
            fullname = Fullname;
            username = Username;
            nik = NIK;
            password = pass;
        }
    }
}
