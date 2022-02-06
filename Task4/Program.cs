using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.Требуется: 
/// Создать класс Invoice.В теле класса создать три поля int account, string customer, string provider, 
/// которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения. 
/// В теле класса создать два закрытых поля string article, int quantity Создать метод расчета стоимости заказа с НДС и без НДС. 
/// Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
/// </summary>
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(0, "OOO Mikma", "ZAO Romashka");
            inv.price = 10;

            Console.WriteLine($"Total with NDS {inv.CalculateTatalWithNDS()}");
            Console.WriteLine($"Total withOut NDS {inv.CalculateTatalWithOutNDS()}");
            Console.ReadLine();
        }
    }
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        private string article;
        private int quantity = 1;
        public double price;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double CalculateTatalWithNDS()
        {
            double total = price * quantity * 1.2;
            return total;
        }
        public double CalculateTatalWithOutNDS()
        {
            double total = price * quantity;
            return total;
        }
    }
}
