using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            bool isWork = true;
            Restourane restourane = new Restourane(10, 10,0);
            while (isWork==true)
            {
                Console.WriteLine();


                Console.WriteLine("Введите 1 если хотите посмотреть сколько доступно столов");
                Console.WriteLine("Введите 2 если хотите добавить бронь");
                Console.WriteLine("Введите 3 если хотите удалить бронь");
                Console.WriteLine("Введите 4 если хотите выйти");
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine();
                        restourane.CheckTables(restourane);
                        break;
                    case 2:
                        restourane.AddReservation(restourane);
                        break;
                    case 3:
                        restourane.DeleteReservation(restourane);
                        break;
                    case 4:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка введите корректное число");
                        break;
                }
            }
        }
    }
}
