using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using  System.Data.SqlClient;
using System.Linq;
using FactoryPepsi;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using static FactoryCocaCola.Program;

namespace FactoryCocaCola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FindUser();// Метод поиска клиента в базе 
            AddUser();// Метод добавления клиента в базу
            //DeleteUse();
            Console.ReadLine();
            var client1 = new Client(new PepsiFactory());
            client1.Water();
            client1.Bottle();
            client1.Cover();
            client1.Volume();
            client1.Pay();
            Console.WriteLine(new string('-', 15));
            var client2 = new Client(new CocaColaFactory());
            client2.Water();
            client2.Bottle();
            client2.Cover();
            client2.Volume();
            client2.Pay();
            Console.ReadLine();
        }
        //Метод поиска зарегистрированного клиента в базе данных
        public static void FindUser()
        {
            using (var db = new RegisterDBContext())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Мы рады приветствовать вас в первый день вашего пути вместе с Coca-Cola" +
                                  "\nВы можете получить скидку на Coca-Cola 2л если Вы являетесь студентом и зарегистрированны в базе компании\n" +
                                  "\nДля продолжения нажмите ENTER\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Вы не зарегистрированы в нашей базе." + "\nВы переходите в другой раздел выбора\n" +
                                  "\nДля перехода нажмите ENTER\n");
                Console.ReadLine();
                Console.WriteLine("Посмотреть Вас в нашей базе ?" + "\nДля продолжения нажмите ENTER\n");
                Console.ReadLine();
                try
                {
                    Console.WriteLine("Введите UserId");
                    var id = int.Parse(Console.ReadLine());
                    var dbContext = new RegisterDBContext();
                    var users = db.Users.Find(id);
                    if (users != null)
                        Console.WriteLine($"\nИмя:{users.NameUser}-Регистрационный номер:{users.RegistrNumber}\n" +
                                          "\nВы зарегистрированны в нашей базе\n");
                  
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите только цифры" + "Для продолжения нажмите ENTER");
                }

                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Для регистрации нового клиента, пожалуйста введите свои данные в базу компании");
            }
            
        }
        // ReSharper disable once CommentTypo
        // Метод добавления регистрации нового пользователя в Базу
        public static void AddUser()
        {
            using (var db = new RegisterDBContext())
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Форма регистрации");
                var users = new Users();
                try
                {
                    Console.WriteLine("Введите имя");
                    users.NameUser = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите номер");


                    users.RegistrNumber = Convert.ToInt32(Console.ReadLine());
                    db.Users.Add(users);
                    db.SaveChanges();
                    Console.WriteLine("Спасибо за регистрацию !");
                    var BottleDiscount = 200 / 100 * 5;
                    var PricebottlesDiscount = 200 - 40;
                    var NameUser = users;
                    var NumberUser = NameUser;
                    if (NameUser != NumberUser) return;
                   
                    Console.WriteLine("Бутылка  COCA-COLA со скидкой в 5%, будут стоить " + PricebottlesDiscount +
                                      "\tруб" +
                                      "\nПожалуйста нажмите Enter, для перехода в другой раздел нашего каталога\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Вы ни чего не ввели в форму регистрации{ex.Message}");
                }
            }
        }
    }
}


    




    


