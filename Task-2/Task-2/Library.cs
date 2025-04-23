using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Library
    {
        public List<Book> Books;
        public List<AbstractPerson> Members;

        public Library ()
        {
            Books = new List<Book>();
            Members = new List<AbstractPerson>();
        }
        public void AddBook (Book book)
        {
            Books.Add(book);
        }
        public void AddMember (AbstractPerson member)
        {
            Members.Add(member);
        }
        public Book FindBookById(int id)
        {
             foreach (Book book in Books)
             {
                if (book.Id == id)
                {
                    return book;
                }
             }
            return null;
        }

        public AbstractPerson FindMemberById(int id)
        {
            foreach (AbstractPerson member in Members)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }
            return null;
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine($"The books in the library :\n{string.Join("\n", Books)}");
        }
        public void DisplayAllMembers()
        {
            Console.WriteLine($"The Members in the library :\n{string.Join("\n", Members)}");
        }
    }
}
