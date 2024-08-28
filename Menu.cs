using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _242Taller3DMartesSemana1
{
    internal class Menu
    {
        private List<Person> people = new List<Person>();

        public void Execute()
        {
            Example();
        }

        private void Example()
        {
            people = new List<Person>();
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción:");
                Console.WriteLine("1. Agregar persona");    
                Console.WriteLine("2. Agregar alumno");
                Console.WriteLine("3. Mostrar datos");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPersonMenu();
                        break;
                    case "2":
                        AddStudentMenu();
                        break;
                    case "3":
                        ShowPeopleMenu();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void ShowPeopleMenu()
        {
            foreach(Person person in people)
            {
                Console.WriteLine(person.GetData());
            }
        }

        private void AddPersonMenu()
        {
            string name= GetNameMenu();
            int age= GetAgeMenu();
            Person person = new Person(name, age);
            people.Add(person);
        }
        private void AddStudentMenu()
        {
            string code = GetCodeMenu();
            string name = GetNameMenu();
            int age = GetAgeMenu();
            Person student = new Student(code,name, age);
            people.Add(student);
        }

        private string GetNameMenu()
        {
            string name;
            Console.WriteLine("\nIntroduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            return name;
        }

        private int GetAgeMenu()
        {
            int age = 0;
            bool continueFlag;
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
            return age;
        }

        private string GetCodeMenu()
        {
            string code;
            Console.WriteLine("Introduce tu código");
            code = Console.ReadLine();
            Console.WriteLine($"Tu código es: {code}");
            return code;
        }



    }
}
