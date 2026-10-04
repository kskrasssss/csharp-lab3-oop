using System;

namespace Lab3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            // Введення даних з клавіатури
            Console.Write("Назва: ");
            book.Title = Console.ReadLine();
            Console.Write("Автор: ");
            book.Author = Console.ReadLine();
            Console.Write("Видавництво: ");
            book.Publisher = Console.ReadLine();
            Console.Write("Рік видання: ");
            book.Year = int.Parse(Console.ReadLine());
            Console.Write("Кількість сторінок: ");
            book.Pages = int.Parse(Console.ReadLine());
            Console.Write("Ціна (грн): ");
            book.Price = double.Parse(Console.ReadLine());
            Console.Write("Поточна сторінка читання: ");
            book.CurrentPage = int.Parse(Console.ReadLine());

            // Демонстрація методів
            Console.WriteLine();
            Console.WriteLine("Ціна зі знижкою 10%: " + book.GetPriceWithDiscount(10) + " грн");
            Console.WriteLine("Залишилось сторінок: " + book.PagesLeft());
            Console.WriteLine("Вік книги: " + book.GetAge(DateTime.Now.Year) + " р.");
        }
    }
}
