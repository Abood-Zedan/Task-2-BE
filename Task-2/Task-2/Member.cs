using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Member : AbstractPerson
    {
        public List<Book> BorrowedBooks;

        public Member(int Id , string Name)
        {
            this.Id = Id;
            this.Name = Name;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook (Book book)
        {
            if(book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine("The book has been successfully borrowed.");
            }
        }
        public void ReturnBook (Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine("The book has been successfully returned.");
            }
        }
        public void DisplayBorrowedBooks ()
        {
            Console.WriteLine($"Borrowed Books :\n{string.Join("\n", BorrowedBooks)}");
        }
        public override string DisplayInfo()
        {
            return $"ID : {Id} , Name : {Name},\nBorrowed books :  {String.Join("\nand ", BorrowedBooks)}";
        }
        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name},\nBorrowed books :{String.Join("\nand ", BorrowedBooks)}";
        }
    }
}
