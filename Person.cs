﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242Taller3DMartesSemana1
{
    internal class Person
    {
        protected string name;
        protected int age;

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string GetData()
        {
            return $"Nombre: {name} - Edad: {age}";
        } 
    }
}
