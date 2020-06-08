using SGU.Volokhina.Entitiess;
using SGU.Volokhina.BLL.Interface;
using SGU.Volokhina.DAL;
using SGU.Volokhina.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;

        public UserLogic()
        {
            this.userDao = new UserDao();
        }

        public int AddUser(User value)
        {
            return this.userDao.AddUser(value);
        }

        public void DeleteUser(int value)
        {
            userDao.DeleteUser(value);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.userDao.GetAllUsers();
        }
    }
}
