using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1:
            Money money = new Money();
            money.Currency = 125;
            money.Cents = 99;

            Console.WriteLine(money);

            Console.WriteLine();

            Product product = new Product();
            product.Price = money;

            product.DecreacePrice(30, 50);
            Console.WriteLine(product);

            Console.WriteLine();

            product.IncreacePrice(7, 35);
            Console.WriteLine(product);
            Console.WriteLine("--------------------------------");
            // Task 2:
            
            Device microwave = new Microwave("Panasonic", "1200 W");
            Device car = new Car("Opel", "Kadett");
            Device kettle = new Kettle("BRAUN", "WK 300");
            Device steamboat = new Steamboat("Mississippi Riverboat", "Mantua Model 734");

            kettle.Show();
            kettle.Sound();
            kettle.Desc();

            Console.WriteLine();

            microwave.Show();
            microwave.Sound();
            microwave.Desc();

            Console.WriteLine();

            car.Show();
            car.Sound();
            car.Desc();

            Console.WriteLine();

            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();

            Console.ReadLine();


        }
    }
}
