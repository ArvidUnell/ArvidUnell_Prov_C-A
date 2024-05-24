using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvidUnell_Prov_C_A
{
    internal class Book
    {
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;

            this.isBorrowed = false;
        }

        private string title;
        private string author;
        private string isbn;
        private bool isBorrowed;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public bool IsBorrowed
        {
            get { return isBorrowed; }
            set { isBorrowed = value; }
        }
    }
}
