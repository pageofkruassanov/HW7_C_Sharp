using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_C_Sharp
{
    internal abstract class Device
    {
        protected string Name { get; set; }
        protected string Characteristics { get; set; }
        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }
        public abstract void Sound();
        public void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }
        public void Desc()
        {
            Console.WriteLine($"Device characteristics: {Characteristics}");
        }
    }
}
