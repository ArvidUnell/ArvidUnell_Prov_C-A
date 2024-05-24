using System;
namespace ArvidUnell_Prov_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //Lägg till böcker
            library.AddBook("Ignition", "John D. Clark", "A204");
            library.AddBook("Sagan om ringen", "JRR Tolkien", "O120");
            library.AddBook("Harry Potter", "JK Rowling", "K002");
            library.AddBook("Percy Jackson", "Rick Riordan", "M034");

            //Lägg till användare
            library.AddUser("Olle Wessman");
            library.AddUser("Arvid Unell");
            library.AddUser("Hugo Myhrberg");

            //Låna böcker
            library.BorrowBook("2", "M034");
            library.BorrowBook("0", "A204");
            library.BorrowBook("2", "O120");

            //Visa tillgängliga böcker
            library.DisplayAvailibleBooks();
            Console.WriteLine();
            //Visa lånade böcker för en användare
            library.DisplayUserBorrowedBooks("2");
            Console.WriteLine();
            //Lämna tillbaka böcker
            library.ReturnBook("2", "M034");
            Console.WriteLine();
            //Visa tillgängliga böcker igen
            library.DisplayAvailibleBooks();
            Console.WriteLine();
            //Visa lånade böcker för en användare igen
            library.DisplayUserBorrowedBooks("2");
            Console.WriteLine();
        }
    }
}
