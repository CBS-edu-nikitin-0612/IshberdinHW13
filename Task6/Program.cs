using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
/// Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
/// Реализуйте вывод на экран информации о пользователе.
/// </summary>
namespace Task6
{
    class Program
    {
        static void Main()
        {
            User user = new User();
            user.Login = "II";
            user.Name = "ilfat";
            user.SurName = "Ishberdin";
            user.Age = 25;
            user.ShowInfo();
            Console.ReadKey();
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public readonly DateTime CreateDate;

        public User()
        {
            CreateDate = DateTime.Now;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Login: {Login}\r\n" +
                $"Name: {Name}\r\n" +
                $"Surname: {SurName}\r\n" +
                $"Age: {Age}\r\n" +
                $"Date of create: {CreateDate.ToString("G")}");
        }
    }
}
