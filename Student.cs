using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242Taller3DMartesSemana1
{
    internal class Student : Person
    {
        private string code;

        public Student(string code, string name, int age) : base(name, age)
        {
            this.code = code;
        }

        public override string GetData()
        {
            return $"Código: {code} - Nombre: {name} - Edad: {age}";
        }

    }
}
