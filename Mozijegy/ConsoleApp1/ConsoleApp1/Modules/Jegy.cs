using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    internal class Jegy
    {
        private Person szemely;
        private string _filmCim;
        private string _vetitesIdopont;
        private int _szekSor;
        private int _szekSzam;

        public Person Szemely
        {
            get { return szemely; }
            set
            {
                if (value == null)
                    throw new ArgumentException("A személy nem lehet null!");

                szemely = value;
            }
        }

        public string FilmCim
        {
            get { return FilmCim; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A film címe nem lehet üres!");

                FilmCim = value.Trim();
            }
        }

        public DateTime VasarlasIdopont
        {
            get { return VasarlasIdopont; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("A vásárlás időpontja nem lehet jövőbeli!");

                VasarlasIdopont = value;
            }
        }

        public int SzekSor
        {
            get { return SzekSor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A szék sora csak pozitív lehet!");

                SzekSor = value;
            }
        }

        public int SzekSzam
        {
            get { return SzekSzam; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A szék száma csak pozitív lehet!");

                SzekSzam = value;
            }
        }

        
        public Jegy(Person szemely, string filmCim, DateTime vasarlasIdopont, int szekSor, int szekSzam)
        {
            Szemely = szemely;
            FilmCim = filmCim;
            VasarlasIdopont = vasarlasIdopont;
            SzekSor = szekSor;
            SzekSzam = szekSzam;
        }

        
        public Jegy(Person szemely, string filmCim)
        {
            Szemely = szemely;
            FilmCim = filmCim;
            VasarlasIdopont = DateTime.Now;
            SzekSor = 1;
            SzekSzam = 1;
        }

        
        public override string ToString()
        {
            return string.Format(
                "{0,-20} | {1,-15} | {2,-16} | Sor: {3,2} Szék: {4,2}",
                Szemely.ToString(),
                FilmCim,
                VasarlasIdopont.ToString("yyyy.MM.dd HH:mm"),
                SzekSor,
                SzekSzam
            );
        }
    }
}
