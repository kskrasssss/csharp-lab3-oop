using System;

namespace Lab3Task2
{
    public class Book
    {
        // 7 приватних полів
        private string title;
        private string author;
        private string publisher;
        private int year;
        private int pages;
        private double price;
        private int currentPage; // на якій сторінці читач зупинився

        // Властивості (доступ до приватних полів)
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Pages { get { return pages; } set { pages = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int CurrentPage { get { return currentPage; } set { currentPage = value; } }

        // Конструктор без параметрів
        public Book()
        {
            title = "Без назви";
            author = "Невідомий";
            publisher = "Невідомо";
            year = 2000;
            pages = 100;
            price = 100;
            currentPage = 0;
        }

        // Конструктор з усіма параметрами
        public Book(string title, string author, string publisher, int year, int pages, double price, int currentPage)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.pages = pages;
            this.price = price;
            this.currentPage = currentPage;
        }

        // Метод 1: ціна з урахуванням знижки (використовує поле price)
        public double GetPriceWithDiscount(double discountPercent)
        {
            return price - price * discountPercent / 100;
        }

        // Метод 2: скільки сторінок залишилось прочитати (поля pages, currentPage)
        public int PagesLeft()
        {
            return pages - currentPage;
        }

        // Метод 3: вік книги (поле year)
        public int GetAge(int currentYear)
        {
            return currentYear - year;
        }
    }
}