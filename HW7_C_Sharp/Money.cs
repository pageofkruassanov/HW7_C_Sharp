using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_C_Sharp
{
    internal class Money
    {
        public int Currency { get; set; }
        public int Cents { get; set; }
        public override string ToString() => $"{Currency}.{Cents}";
    }
}
