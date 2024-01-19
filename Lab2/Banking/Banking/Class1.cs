using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class User
    {
        public string name;
        public string password;
        public string DOB;
        public long balance;
        public string lastAccessed;

        public User(string name, string password, string DOB, long balance, string lastAccessed)
        {
            this.name = name;
            this.password = password;
            this.DOB = DOB;
            this.balance = balance;
            this.lastAccessed = lastAccessed;
        }

        public string pwd()
        {
            return password;
        }

    }
}
