using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvidUnell_Prov_C_A
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        /// <summary>
        /// Lägger till en bok i systemet
        /// </summary>
        /// <param name="name">Bokens namn</param>
        /// <param name="author">Bokens författare</param>
        /// <param name="isbn">Bokens ISBN</param>
        public void AddBook(string name, string author, string isbn)
        {
            books.Add(new Book(name, author, isbn));
        }
        /// <summary>
        /// Lägger till en användare i systemet
        /// </summary>
        /// <param name="name">Namnet på användaren som ska läggas till</param>
        public void AddUser(string name)
        {
            users.Add(new User(name, users.Count().ToString())); //IDt är samma som indexet
        }

        /// <summary>
        /// Lånar ut en bok till en viss användare
        /// </summary>
        /// <param name="userID">Användaren som boken lånas ut till</param>
        /// <param name="isbn">ISBN av boken som ska lånas ut</param>
        public void BorrowBook(string userID, string isbn)
        {
            int libraryBookIndex = -1;
            for(int i = 0; i < books.Count; i++) //Hittar bokens index
            {
                if(books[i].ISBN == isbn)
                {
                    libraryBookIndex = i;
                }
            }

            if (libraryBookIndex != -1 && books[libraryBookIndex].IsBorrowed == false && users.Count() - 1 > int.Parse(userID)) //Man kan endast låna en bok om den finns i biblioteket och användaren finns i systemet
            {               
                books[libraryBookIndex].IsBorrowed = true;
                users[int.Parse(userID)].BorrowedBooks.Add(books[libraryBookIndex]);
            }
        }
        /// <summary>
        /// Lämnar tillbaka en bok från en viss användare
        /// </summary>
        /// <param name="userID">AnvändarIDt som lämnar tillbaka boken</param>
        /// <param name="isbn">ISBN till boken som lämnas tillbaka</param>
        public void ReturnBook(string userID, string isbn)
        {
            int userIDInt = int.Parse(userID);

            if (users.Count() - 1 > userIDInt) //Man kan bara lämna tillbaka en bok om man har lånat den
            {
                int userBookIndex = -1;
                for (int i = 0; i < users[userIDInt].BorrowedBooks.Count; i++) //Hittar bokens index hos användaren
                {
                    if (users[userIDInt].BorrowedBooks[i].ISBN == isbn)
                    {
                        userBookIndex = i;
                    }
                }

                if (userBookIndex != -1)
                {
                    books[books.IndexOf(users[userIDInt].BorrowedBooks[userBookIndex])].IsBorrowed = false; //Bibliotekets system kommer ha boken om man har lyckats låna den
                    users[int.Parse(userID)].BorrowedBooks.RemoveAt(userBookIndex);
                }               
            }
        }

        /// <summary>
        /// Visar alla böcker som inte är utlånade
        /// </summary>
        public void DisplayAvailibleBooks()
        {
            foreach (Book book in books)
            {
                if (book.IsBorrowed == false)
                {
                    Console.WriteLine(book.Title + ", " + book.Author + ", " + book.ISBN);
                }
            }
        }
        /// <summary>
        /// Visar alla böcker en viss användare har lånat
        /// </summary>
        /// <param name="userID">Användaren vars böcker ska visas</param>
        public void DisplayUserBorrowedBooks(string userID)
        {
            if(users.Count() - 1 > int.Parse(userID))
            {
                foreach (Book book in users[int.Parse(userID)].BorrowedBooks)
                {
                    Console.WriteLine(book.Title + ", " + book.Author + ", " + book.ISBN);
                }
            }
            
        }
    }
}
