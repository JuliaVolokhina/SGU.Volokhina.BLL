using SGU.Volokhina.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.DAL.Interface
{
    public interface IUserDao
    {
        IEnumerable<User> GetAllUsers();

        int AddUser(User value);

        void DeleteUser(int value);
    }
}
