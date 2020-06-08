using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU.Volokhina.Entitiess
{
    public class User 
    {
        public int IDUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{IDUser} {FirstName} {LastName} {DateOfBirth} {Age}";
        }        
    }
}