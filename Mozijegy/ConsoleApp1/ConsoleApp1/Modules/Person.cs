using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    internal class Person
    {
        private static string _vezeteknev;
        private static string _keresztnev;

        public Person(string vezeteknev, string keresztnev)
        {
            vezeteknev=vezeteknev.Trim();
            keresztnev = keresztnev.Trim();
        }


        public static string Vezeteknev { get => _vezeteknev; set => _vezeteknev = value; }
        public static string Keresztnev { get => _keresztnev; set => _keresztnev = value; }



    }
}
