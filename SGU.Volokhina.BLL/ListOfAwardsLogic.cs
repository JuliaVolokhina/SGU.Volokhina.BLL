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
    public class ListOfAwardsLogic : IListOfAwardsLogic
    {
        private IListOfAwardsDao listOfAwardsDao;

        public ListOfAwardsLogic()
        {
            this.listOfAwardsDao = new ListOfAwardsDao();
        }

        public int AddAwardToUser(ListOfAwards value)
        {
            return this.listOfAwardsDao.AddAwardToUser(value);
        }

        public IEnumerable<ListOfAwards> GetAllUsersWithAwards()
        {
            return this.listOfAwardsDao.GetAllUsersWithAwards();
        }
    }
}    