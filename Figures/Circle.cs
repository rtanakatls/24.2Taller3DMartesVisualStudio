using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242Taller3DMartesSemana1.Figures
{
    internal class Circle : Shape
    {
        private float radius;
        private float pi = 3.14f;

        public Circle(float radius)
        {
            name = "Círculo";
            this.radius = radius;
        }

        public override float GetArea()
        {
            return pi * radius * radius;
        }
    }
}
