using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
    class Program
    {
        static List<Szuletesek> szuletesek = new List<Szuletesek>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("vas.txt");
            while (!sr.EndOfStream)
            {
                szuletesek.Add(new Szuletesek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
