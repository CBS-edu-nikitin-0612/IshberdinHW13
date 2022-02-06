using System;
using System.Collections.Generic;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс Converter. 
/// В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
/// и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public Converter(double usd, double eur, double rub). 
/// Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну. 
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(0.35, 0.31, 2.707);
            double value = 1;

            foreach (string currency in new List<string> { "usd", "EUR", "Rub" })
            {
                Console.WriteLine($"{value} гривен = {converter.GRNConvertTo(value, currency)} {currency}");
            }

            foreach (string currency in new List<string> { "usd", "EUR", "Rub" })
            {
                Console.WriteLine($"{value} {currency} = {converter.ConvertToGRN(value, currency)} гривен");
            }
            Console.ReadKey();

        }
    }

    class Converter
    {
        double Usd { get; }
        double Eur { get; }
        double Rub { get; }
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public double ConvertToGRN(double value, string currency)
        {
            if (currency.ToLower() == "usd") return Usd * value;
            else if (currency.ToLower() == "eur") return Eur * value;
            else if (currency.ToLower() == "rub") return Rub * value;
            else return 0;
        }
        public double GRNConvertTo(double value, string currency)
        {
            if (currency.ToLower() == "usd") return Usd / value;
            else if (currency.ToLower() == "eur") return Eur / value;
            else if (currency.ToLower() == "rub") return Rub / value;
            else return 0;
        }
    }
}
