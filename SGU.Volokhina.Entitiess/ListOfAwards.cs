using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.Entitiess
{
    public class ListOfAwards
    {
        public int IDUser { get; set; }

        public int IDAward { get; set; }

        public override string ToString()
        {
            return $"{IDUser} {IDAward}";
        }
    }
}
