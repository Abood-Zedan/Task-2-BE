namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Member us1 = new Member(1,"Ahmad");
            //Member us2 = new Member(2, "Abood");
            //Member us3 = new Member(3, "Omar");

            //Book bk1 = new Book()
            //{
            //    Id = 1,
            //    Title = "The Mind",
            //    AuthorName = "Omar",
            //    IsAvailable = true,
            //};
            //Book bk2 = new Book()
            //{
            //    Id = 2,
            //    Title = "The Heart",
            //    AuthorName = "Baker",
            //    IsAvailable = true,
            //};
            //us1.BorrowBook(bk2);
            //us1.BorrowBook(bk1);

            //Console.WriteLine(us3.BorrowBook(bk2));
            //Console.WriteLine(us3.DisplayBorrowedBooks());

            Library library = new Library();

            // إضافة كتب
            library.AddBook(new Book(1, "1984", "George Orwell"));
            library.AddBook(new Book(2, "The Hobbit", "J.R.R. Tolkien"));
            library.AddBook(new Book(3, "Clean Code", "Robert C. Martin"));

            // إضافة أعضاء
            library.AddMember(new Member(1, "Ali"));
            library.AddMember(new Member(2, "Sara"));

            while (true)
            {
                Console.WriteLine("\n--- Library Menu ---");
                Console.WriteLine("1. Show all books");
                Console.WriteLine("2. Show all members");
                Console.WriteLine("3. Borrow book");
                Console.WriteLine("4. Return book");
                Console.WriteLine("5. Show member borrowed books");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        library.DisplayAllBooks();
                        break;

                    case "2":
                        library.DisplayAllMembers();
                        break;

                    case "3":
                        Console.Write("Enter member ID: ");
                        int mid = int.Parse(Console.ReadLine());
                        Console.Write("Enter book ID: ");
                        int bid = int.Parse(Console.ReadLine());

                        AbstractPerson absMember = library.FindMemberById(mid);
                        Book bookToBorrow = library.FindBookById(bid);

                        if (absMember is Member m1 && bookToBorrow != null)
                            m1.BorrowBook(bookToBorrow);
                        else
                            Console.WriteLine("Invalid member or book ID.");
                        break;

                    case "4":
                        Console.Write("Enter member ID: ");
                        mid = int.Parse(Console.ReadLine());
                        Console.Write("Enter book ID: ");
                        bid = int.Parse(Console.ReadLine());

                        absMember = library.FindMemberById(mid);
                        Book bookToReturn = library.FindBookById(bid);

                        if (absMember is Member m2 && bookToReturn != null)
                            m2.ReturnBook(bookToReturn);
                        else
                            Console.WriteLine("Invalid member or book ID.");
                        break;

                    case "5":
                        Console.Write("Enter member ID: ");
                        mid = int.Parse(Console.ReadLine());
                        absMember = library.FindMemberById(mid);
                        if (absMember is Member m3)
                            m3.DisplayBorrowedBooks();
                        else
                            Console.WriteLine("Invalid member ID.");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
