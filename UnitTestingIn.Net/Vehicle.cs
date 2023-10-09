using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingIn.Net
{
    public class Vehicle
    {
        public string Licence { get; set; }
        public bool Pass { get; set; }
        public Vehicle(string licence, bool pass)
        {
            this.Licence = licence;
            this.Pass = pass;
        }
    }
}
