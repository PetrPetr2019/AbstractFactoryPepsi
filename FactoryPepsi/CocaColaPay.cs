using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace FactoryPepsi
{

    // Конкретный класс CocaColaPay
    internal class CocaColaPay : AbstractPay
    {
        public override void Pay(int sumBotleCola1, int sumBotleCola2)
        {
            var again = "Yes";
            while (again == "Yes")
            {
                //while (true)
                //{
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(
                    "Выберите  цифру c напитком и нажмите: 1 или 2:\n(1: COCA-COLA, 0,33л -  2:COCA-COLA, 1л)\t");
                Console.WriteLine(new string(' ', 20));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Вы можете получить скидку 5%, если возьмете 4 бутылки  COCA-COLA, 1л" +
                                  "\nДля выбора нажмите цифру 4 на клавиатуре\t");
                try
                {
                    var discountCocaLitre = Convert.ToInt32(Console.ReadLine());
                    var FourbottleDiscount = 800 / 100 * 5;
                    var PriceOfthebottlesDiscount = 800 - 40;
                    if (discountCocaLitre > 3 && discountCocaLitre < 5)
                    {
                        Console.WriteLine("4 бутылки  COCA-COLA со скидкой в 5%, будут стоить " +
                                          PriceOfthebottlesDiscount + "\tруб");
                    }
                    else if (discountCocaLitre == 1)
                    {
                        Console.WriteLine("Вы выбрали  COCA-COLA, 0,33л " + $"Цена:{sumBotleCola1} руб");
                        Console.WriteLine("Хотите продолжить выбор нажмите ENTER");
                        Console.ReadLine();
                    }
                    else if (discountCocaLitre == 2)
                    {
                        Console.WriteLine("Вы выбрали  COCA-COLA, 1л " + $"Цена:{sumBotleCola2} руб");
                        Console.WriteLine("Хотите продолжить выбор нажмите ENTER");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Вы можете выбрать только 4 напитка  с 5% скидкой");
                        Console.WriteLine("Хотите продолжить выбор нажмите ENTER");
                        Console.ReadLine();
                    }

                    if (discountCocaLitre == 3 || discountCocaLitre == 0)
                        Console.WriteLine("Не правильный выбор нажмите ENTER");
                    Console.WriteLine("\nДля повтора неберите (Yes, для выхода No)  а затем нажмите ENTER");
                    again = Convert.ToString(Console.ReadLine());

                    //string rep = Console.ReadLine();
                    //if (rep == "Yes")continue;
                    //if(rep=="No")break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы можете вводить, только цифры." + "\nДля продолжения нажмите ENTER\t");
                    Console.ReadLine();
                }

            }
        }
    }
}




    



