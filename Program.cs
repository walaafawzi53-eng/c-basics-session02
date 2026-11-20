using System;

namespace CSharpAssignment
{
    // Q01: Create a Book class with Title and Pages.
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("========== C# Assignment ==========");

            // Q01
            Console.WriteLine("\nQ01 - Book class");
            Book book = new Book("C# Basics", 464);
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Pages: {book.Pages}");

            // Q02
            Console.WriteLine("\nQ02 - Object methods");
            Console.WriteLine($"ToString(): {book.ToString()}");
            Console.WriteLine($"Equals(book): {book.Equals(book)}");
            Console.WriteLine($"GetHashCode(): {book.GetHashCode()}");
            Console.WriteLine($"GetType(): {book.GetType()}");

            // Q03
            Console.WriteLine("\nQ03 - Fix the type error");
            // Original: int pages = "464"; // Compile-time error
            int pages = 464;
            Console.WriteLine($"Pages: {pages}");

            // Q04
            Console.WriteLine("\nQ04 - try / catch / finally");
            try
            {
                int divisor = 0;
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            // Q05
            Console.WriteLine("\nQ05 - Implicit conversion");
            int numberOfPages = 300;
            double pagesAsDouble = numberOfPages;
            Console.WriteLine($"int value: {numberOfPages}");
            Console.WriteLine($"double value: {pagesAsDouble}");

            // Q06
            Console.WriteLine("\nQ06 - Explicit conversion (cast)");
            double price = 49.99;
            int priceAsInt = (int)price;
            Console.WriteLine($"Original price: {price}");
            Console.WriteLine($"Converted price: {priceAsInt}");

            // Q07
            Console.WriteLine("\nQ07 - Convert class");
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine($"Converted pages: {convertedPages}");

            // Q08
            Console.WriteLine("\nQ08 - Parse and TryParse");
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"Parsed year: {year}");

            string badText = "abc";
            if (int.TryParse(badText, out int parsedBadText))
            {
                Console.WriteLine($"Parsed value: {parsedBadText}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            // Q09
            Console.WriteLine("\nQ09 - Convert int to string");
            int pageCount = 464;
            string pageCountText = pageCount.ToString();
            Console.WriteLine($"String value: {pageCountText}");
            Console.WriteLine($"Type: {pageCountText.GetType()}");

            // Q10
            Console.WriteLine("\nQ10 - Boxing and unboxing");
            int copies = 100;
            object boxedCopies = copies;       // Boxing
            int unboxedCopies = (int)boxedCopies; // Unboxing
            Console.WriteLine($"Original int: {copies}");
            Console.WriteLine($"Unboxed int: {unboxedCopies}");

            Console.WriteLine("\n========== End of Assignment ==========");
        }
    }
}
