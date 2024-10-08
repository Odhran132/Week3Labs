// See https://aka.ms/new-console-template for more information
class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;



    void DisplayInfo()
    {
        Console.WriteLine("Book information: ");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book Title:  {Title}");
        Console.WriteLine($"Book Author:  {Author}");
        Console.WriteLine($"Book ISBN:  {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Author";
        book.ISBN = "123456677";
        book.NoOfPages = 247;

        Console.WriteLine($"Book title: {book.Title}");

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "112233445";
        book2.NoOfPages = 209;

        book.DisplayInfo();
        book2.DisplayInfo();

        /*
        Console.WriteLine($"Book Title:  (book2.Title)");
        Console.WriteLine($"Book Author:  (book2.Author)");
        Console.WriteLine($"Book ISBN:  (book2.ISBN)");
        */
    }

}