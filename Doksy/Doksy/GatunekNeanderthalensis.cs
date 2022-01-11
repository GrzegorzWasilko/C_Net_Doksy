using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class GatunekNeanderthalensis:RodzajCzlowiek
    {
        public GatunekNeanderthalensis()
        {
            gatunek = "Neanderthalensis";
            przydomek = "Neandertańczyk";
            end = "do około 30 tyś lat temu ";
            pojawienie = 300000;
            zdanie = "Argh Argh ! ";
            imie = "nieznane";
        }
        public GatunekNeanderthalensis(string imie) : this()
        {
            Imie = imie;
        }
        protected override void slabeMocneStrony()
        {
            Console.Write("\nSłabe strony to:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Tragiczny PR, obiekt żartów w kreskówkach\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nMocne strony to:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"odporni na klimat epoki lodowcowej, opiekowali sie osobami strszymi i niepełnosprawnymi\n\n");
            Console.ResetColor();
        }
    }
}
