using System;

namespace ConsoleApp13
{
    public class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

    }
    public class Title
    {
        public string name;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\nИмя книги: {name}. ");
            Console.ResetColor();
        }
    }
    public class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nАвтор книги: {author}. ");
            Console.ResetColor();
        }
    }
    public class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\nКонтент книги: {content}. ");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Title title1 = new Title() { name = "The Alchemist" };
            Author author1 = new Author() { author = "Paulo Coelho" };
            Content content1 = new Content() { content = "this book is about the search for truth" };
            Book book = new Book() { title = title1, author = author1, content = content1 };
            book.title.Show();
            book.author.Show();
            book.content.Show();

            Console.ReadKey();

        }
    }
}
