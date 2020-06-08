using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.Entitiess
{
    public class Award 
    {
        public int IDAward { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{IDAward} {Title}";
        }
    }
}