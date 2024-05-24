using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvidUnell_Prov_C_A
{
    internal class User
    {
        public User(string name, string userID)
        {
            this.name = name;

            this.userID = userID;
        }

        private string name;
        private string userID;
        private List<Book> borrowedBooks = new List<Book>();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public List<Book> BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }
    }
}
