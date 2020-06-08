using SGU.Volokhina.Entitiess;
using SGU.Volokhina.BLL;
using SGU.Volokhina.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.PL
{
    public static class LogicPL
    {
        private static IUserLogic userLogic = new UserLogic();
        private static IAwardLogic awardLogic = new AwardLogic();
        private static IListOfAwardsLogic listOfAwardsLogic = new ListOfAwardsLogic();

        public static void AddUser()
        {
            Console.WriteLine("Введите ID");
            var idUser = Console.ReadLine();

            Console.WriteLine("Введите имя");
            var firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            var lastName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var dateOfBirth = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            var age = Console.ReadLine();

            var currentUser = new User()
            {
                IDUser = Int32.Parse(idUser),
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Age = Int32.Parse(age)
            };

            userLogic.AddUser(currentUser);
        }

        public static void AddAward()
        {
            Console.WriteLine("Введите название награды");
            var title = Console.ReadLine();

            var currentAward = new Award()
            {
                Title = title
            };

            awardLogic.AddAward(currentAward);
        }

        public static void DeleteUser()
        {
            Console.WriteLine("Введите ID пользователя для удаления:");
            int value = int.Parse(Console.ReadLine());

            userLogic.DeleteUser(value);
        }

        public static void GetAllUsers()
        {
            var collection = userLogic.GetAllUsers();
            foreach (var item in userLogic.GetAllUsers())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllAwards()
        {
            var collection = awardLogic.GetAllAwards();
            foreach (var item in awardLogic.GetAllAwards())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllUsersWithAwards()
        {
            var collection = listOfAwardsLogic.GetAllUsersWithAwards();
            foreach (var item in listOfAwardsLogic.GetAllUsersWithAwards())
            {
                Console.WriteLine(item);
            }
        }

        public static void AddAwardToUser()
        {
            Console.WriteLine("Введите ID пользователя");
            var idUser = Console.ReadLine();

            Console.WriteLine("Введите ID награды");
            var idAward = Console.ReadLine();


            var currentlist = new ListOfAwards()
            {
                IDUser = Int32.Parse(idUser),
                IDAward = Int32.Parse(idAward)
            };

            listOfAwardsLogic.AddAwardToUser(currentlist);
        }
    }
}