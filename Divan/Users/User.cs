using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan.Users
{
    class User
    {
        private string firstName;
        private string lastName;
        private string nationalID;
        private string username;
        private string password;
        private Boolean loggedIn;

        public Boolean LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }

        public string Password
        {
            set { password = Utility.GetMd5Hash(value); }
        }

        public Boolean CheckPassword(string password)
        {
            return Utility.GetMd5Hash(password) == this.password;
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        
        public string NationalID
        {
            get { return nationalID; }
            set { nationalID = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public void Login()
        {
            this.LoggedIn = true;
        }

        public void Logout()
        {
            this.LoggedIn = false;
        }

        public virtual string[] GetPermissions()
        {
            return new string[] { };
        }
        
    }
}
