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
            Example();
        }

        private void Example()
        {
            Person[] people = new Person[0];

            while (true)
            {
                string name;
                int age = 0;
                bool continueFlag;
                Console.WriteLine("\nIntroduce tu nombre");
                name = Console.ReadLine();
                Console.WriteLine($"Hola {name}");
                continueFlag = true;
                while (continueFlag)
                {
                    Console.WriteLine("Introduce tu edad");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Tienes {age} años");
                    if (age < 0)
                    {
                        Console.WriteLine("Edad no válida");
                    }
                    else if (age < 18)
                    {
                        continueFlag = false;
                        Console.WriteLine("Eres menor de edad");
                    }
                    else
                    {
                        continueFlag = false;
                        Console.WriteLine("Eres mayor de edad");
                    }
                }
                Person[] temp = new Person[people.Length + 1];
                for (int i = 0; i < people.Length; i++)
                {
                    temp[i] = people[i];
                }
                people = temp;
                people[people.Length - 1] = new Person(name, age);
                foreach(Person person in people)
                {
                    Console.WriteLine($"Nombre: {person.Name}, Edad: {person.Age}");
                }
            }
        }

        private void ModuleExecute()
        {
            int a;
            int b;
            Console.WriteLine("Introduce número 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce número 2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"El residuo de {a} entre {b} es {a % b}");
        }

    }
}
