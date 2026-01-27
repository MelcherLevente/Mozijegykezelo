using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Person
    {
        
        private string vezeteknev;
        private string keresztnev;

        
        public string Vezeteknev
        {
            get { return vezeteknev; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A vezetéknév nem lehet üres!");

                vezeteknev = value.Trim();
            }
        }

        public string Keresztnev
        {
            get { return keresztnev; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A keresztnév nem lehet üres!");

                keresztnev = value.Trim();
            }
        }

        
        public Person(string vezeteknev, string keresztnev)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
        }

        
        public Person(string vezeteknev)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = "Ismeretlen";
        }

        
        public override string ToString()
        {
            return $"{Vezeteknev} {Keresztnev}";
        }
    }


}

