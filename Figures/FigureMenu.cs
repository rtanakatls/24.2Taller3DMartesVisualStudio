using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242Taller3DMartesSemana1.Figures
{
    internal class FigureMenu
    {
        private List<Shape> shapes;

        public FigureMenu()
        {
            shapes = new List<Shape>();
        }

        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción: ");
                Console.WriteLine("1. Agregar círculo");
                Console.WriteLine("2. Agregar triángulo");
                Console.WriteLine("3. Agregar rectángulo");
                Console.WriteLine("4. Mostrar datos");
                Console.WriteLine("0. Salir");
                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddCircleMenu();
                        break;
                    case "2":
                        AddTriangleMenu();
                        break;
                    case "3":
                        AddRectangleMenu();
                        break;
                    case "4":
                        ShowShapesMenu();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }

            }
        }

        private void AddCircleMenu()
        {
            Console.WriteLine("Introduce el radio: ");
            float radius = float.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            shapes.Add(circle);
        }

        private void AddTriangleMenu()
        {
            Console.WriteLine("Introduce la base: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura: ");
            float h = float.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(b, h);
            shapes.Add(triangle);
        }

        private void AddRectangleMenu()
        {
            Console.WriteLine("Introduce la base: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura: ");
            float h = float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(b, h);
            shapes.Add(rectangle);
        }

        private void ShowShapesMenu()
        {
            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} tiene de área {shape.GetArea()}");
            }
        }
    }
}
