using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    internal class Mozi
    {
        private List<Jegy> jegyek;

        // property (csak olvasható kívülről)
        public List<Jegy> Jegyek
        {
            get { return jegyek; }
        }

        // konstruktor
        public Mozi()
        {
            jegyek = new List<Jegy>();
        }

        // =========================
        // CSV BEOLVASÁS
        // =========================
        public void CsvBeolvas(string fajlNev)
        {
            if (!File.Exists(fajlNev))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A CSV fájl nem található!");
                Console.ResetColor();
                return;
            }

            string[] sorok = File.ReadAllLines(fajlNev);

            for (int i = 1; i < sorok.Length; i++) // fejléc kihagyása
            {
                string[] adatok = sorok[i].Split(';');

                string vezeteknev = adatok[0];
                string keresztnev = adatok[1];
                string filmCim = adatok[2];
                DateTime vasarlasIdo = DateTime.Parse(adatok[3]);
                int szekSor = int.Parse(adatok[4]);
                int szekSzam = int.Parse(adatok[5]);

                Person p = new Person(vezeteknev, keresztnev);
                Jegy t = new Jegy(p, filmCim, vasarlasIdo, szekSor, szekSzam);

                jegyek.Add(t);
            }
        }
    }
}
