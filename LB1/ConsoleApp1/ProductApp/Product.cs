using System;

namespace ProductApp
{
    class Product //оголошення класу 
    {
        // Інкапсульовані поля
        private string name;
        private decimal price;
        private int quantity;

        // Конструктор
        public Product(string name, decimal price, int quantity)
        {
            Name = name;       //Використовуємо властивість, щоб застосувати перевірку
            Price = price;
            this.quantity = quantity;
        }

        // Властивості
        public string Name //Властивість для доступу до name. Через неї можна читати і змінювати назву товару.
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва товару не може бути порожньою!");
                name = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути меншою за 0!");
                price = value;
            }
        }

        public int Quantity => quantity;  // Тільки для читання

        public decimal TotalValue => price * quantity;  // Автоматичний розрахунок

        // Методи
        public void Restock(int amount) //Метод для поповнення товару.
        {
            if (amount <= 0)
                throw new ArgumentException("Кількість для поповнення має бути більше 0!");
            quantity += amount;
            Console.WriteLine($"Поповнено {amount} шт. Новий залишок: {quantity} шт.");
        }

        public void Sell(int amount) //Метод для продажу товару.
        {
            if (amount <= 0)
                throw new ArgumentException("Кількість для продажу має бути більше 0!");
            if (amount > quantity)
                throw new InvalidOperationException("Недостатньо товару на складі!");
            quantity -= amount;
            Console.WriteLine($"Продано {amount} шт. Залишок: {quantity} шт.");
        }

        public string GetInfo() //Метод, який повертає рядок з повною інформацією про товар.
        {
            return $"Товар: {Name}, Ціна: {Price} грн, Кількість: {Quantity} шт., Загальна вартість: {TotalValue} грн";
        }
    }
}
