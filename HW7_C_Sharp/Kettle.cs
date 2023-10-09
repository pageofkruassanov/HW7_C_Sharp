using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW7_C_Sharp
{
    internal class Kettle : Device
    {
        public Kettle(string name, string characteristics)
            :
            base(name, characteristics)
        { }
        public override void Sound()
        {
            Console.WriteLine($"Steaming wistle of a {Name} kettle");
        }
    }
}
