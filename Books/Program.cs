/*

Task: Build a Simple C# Console Application for Managing Books
Objective: Create a console application that manages a list of books with basic CRUD operations (Create, Read, Update, Delete).
Steps:
Create a Book class with properties for ID, Title, Author, and Publication Year.
In the Main method, create a menu with options:
Add a new book.
View all books.
Edit a book (by ID).
Delete a book (by ID).
Exit.
Requirements:
Add a Book: Prompt the user to input the book details and add it to a list.
View Books: Display all books currently in the list.
Edit a Book: Allow the user to edit a book’s details using its ID.
Delete a Book: Remove a book by its ID.

*/
using Book;

class Program
{
    public static void Main(string[] args) {
        Console.WriteLine("Enter one option from the menu: \n 1. Add new book \n 2. View all books \n 3. Edit a book \n 4. Delete a book");
        

        List<int> database = [1, 2, 3, 4];
        int bookId = 0;

        while (true)
        {
            string userOption = Console.ReadLine();

            if (userOption == "1") {
                Console.WriteLine("Enter book title");
                string title = Console.ReadLine();
                Console.WriteLine("Enter book publication year");
                string publicationYear = Console.ReadLine();
                Console.WriteLine("Enter book author");
                string author = Console.ReadLine();
                database.Add(bookId++);
                foreach (var item in database)
                    {
                        Console.WriteLine(item);
                    }
            } else if (userOption == "2") {
                foreach (var item in database)
                {
                    Console.WriteLine(item);
                }
            } else if (userOption == "3") {
                // Console.WriteLine("Please select the book that you want to edit.");
                // int index = 0;

                // foreach (var item in database)
                // {
                //     index++;
                //     Console.WriteLine($"{index} {item}");
                // }
                // string book = Console.ReadLine();
                // string title = Console.WriteLine("Enter book title");
                // Console.WriteLine("Enter book title");
                // Console.WriteLine("Enter book title");
                
                // database[index] = Book(title=title);
            } else if (userOption == "4") {
                Console.WriteLine("Please select the book that you want to delete.");
                foreach (var item in database)
                    {
                        Console.WriteLine(item);
                    }
                string bookIdToDelete = Console.ReadLine();
                if (bookIdToDelete == "1") {
                    database.Remove(1);
                    foreach (var item in database)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

    }
}