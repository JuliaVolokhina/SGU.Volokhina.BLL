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
    public class AwardLogic : IAwardLogic
    {
        private IAwardDao awardDao;

        public AwardLogic()
        {
            this.awardDao = new AwardDao();
        }

        public int AddAward(Award value)
        {
            return this.awardDao.AddAward(value);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return this.awardDao.GetAllAwards();
        }
    }
}