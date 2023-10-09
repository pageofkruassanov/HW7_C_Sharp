using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW7_C_Sharp
{
    internal class Microwave : Device
    {
        public Microwave(string name, string characteristics)
            :
            base(name, characteristics)
        { }
        public override void Sound()
        {
            Console.WriteLine($"{Name} microwave bell sound");
        }
    }
}
