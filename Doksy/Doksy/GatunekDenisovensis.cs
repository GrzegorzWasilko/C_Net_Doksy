using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class GatunekDenisovensis : RodzajCzlowiek
    {
        public GatunekDenisovensis() 
        {
            gatunek = "Denisowianie";
            przydomek = "Neandertańczyk";
            end = "do około 50 tyś lat temu ";
            pojawienie = 300000;
            zdanie = "mehele mehele !! ";
            imie = "nieznane";
        }
        public GatunekDenisovensis(string imie):this()
        {
            Imie = imie;
        }
    }
}
