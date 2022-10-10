using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasmegye
{
    class Szuletesek
    {
        private string nem;
        private string szuletes;
        private DateTime szuldatum;
        private string azonosito;
        private string egyedikod;
        private string teljesazonosito;
        public string Nem { get => nem; set => nem = value; }
        public string Szuletes { get => szuletes; set => szuletes = value; }
        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Egyedikod { get => egyedikod; set => egyedikod = value; }
        public string Teljesazonosito { get => teljesazonosito; set => teljesazonosito = value; }
        public DateTime Szuldatum { get => szuldatum; set => szuldatum = value; }
    }
}
