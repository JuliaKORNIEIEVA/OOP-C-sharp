using System;

namespace ProductApp
{
    class Program
    {
        static void Main()
        {
            // Створюємо товар
            Product product = new Product("Ноутбук", 25000, 10);

            // Виводимо інформацію
            Console.WriteLine(product.GetInfo());

            // Поповнюємо склад
            product.Restock(5);
            Console.WriteLine(product.GetInfo());

            // Продаємо товар
            product.Sell(7);
            Console.WriteLine(product.GetInfo());

            // Спроба продати більше, ніж є в наявності (викличе помилку)
            try
            {
                product.Sell(10);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Помилка: {e.Message}");
            }

            // Завершення програми
            Console.WriteLine("Програма завершила роботу.");
        }
    }
}