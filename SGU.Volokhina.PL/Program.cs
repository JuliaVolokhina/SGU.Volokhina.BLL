using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.PL
{
    public class Program
    {
        static void Main(string[] args) 
        {
            bool A = true;
            while (A)
            {
                Console.WriteLine("1 - добавить пользователя");
                Console.WriteLine("2 - удалить пользователя");
                Console.WriteLine("3 - вывести список пользователей");
                Console.WriteLine("4 - добавить вид награды");
                Console.WriteLine("5 - вывести список наград");
                Console.WriteLine("6 - добавить награду пользователю");
                Console.WriteLine("7 - вывести список пользователей и наград");
                Console.WriteLine();
                Console.WriteLine("Введите действие:");
                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        LogicPL.AddUser();
                        break;
                    case "2":
                        LogicPL.DeleteUser();
                        break;
                    case "3":
                        LogicPL.GetAllUsers();
                        break;
                    case "4":
                        LogicPL.AddAward();
                        break;
                    case "5":
                        LogicPL.GetAllAwards();
                        break;
                    case "6":
                        LogicPL.AddAwardToUser();
                        break;
                    case "7":
                        LogicPL.GetAllUsersWithAwards();
                        break;
                    default:
                        A = false;
                        break;
                }
            }
        }
    }
}