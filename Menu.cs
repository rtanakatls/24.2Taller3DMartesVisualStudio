using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242Taller3DMartesSemana1
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            Console.WriteLine("Introduce tu edad");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tienes {age} años");
            if(age<18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad");
            }
        }
    }
}
