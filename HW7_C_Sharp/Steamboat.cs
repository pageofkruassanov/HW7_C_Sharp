using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW7_C_Sharp
{
    internal class Steamboat : Device
    {
        public Steamboat(string name, string characteristics)
            :
            base(name, characteristics)
        { }
        public override void Sound()
        {
            Console.WriteLine($"Steaming whistle of a {Name} steamboat");
        }
    }
}