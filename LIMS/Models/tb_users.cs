using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Windows.Forms;
namespace LimsModel
{
    public class tb_users
    {
        private string depid;
        public string Depid
        {
            get { return depid; }
            set { depid = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private DateTime leavedate;
        public DateTime Leavedate
        {
            get { return leavedate; }
            set { leavedate = value; }
        }
        private DateTime joindate;
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }
        private int userrole;
        public int Userrole
        {
            get { return userrole; }
            set { userrole = value; }
        }
        private string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
    }
}
