using SGU.Volokhina.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.DAL.Interface
{
    public interface IAwardDao
    {
        IEnumerable<Award> GetAllAwards();

        int AddAward(Award value);
    }
}