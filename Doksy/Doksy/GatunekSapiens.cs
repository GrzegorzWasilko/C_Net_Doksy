using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class GatunekSapiens : RodzajCzlowiek
    {
        public GatunekSapiens()
        {
            gatunek = "HomoSapiens";
            przydomek = "człowiek rozumny";
            end = " aż do dziś, mogą wyginąć do 2100 roku";
            pojawienie = 300000;
            zdanie = "bla bla bla ";
            imie = "nieznane";

        }
        public GatunekSapiens(string imie):this()
        {
            Imie = imie;
        }

        public void odezwij_sie(string przemowa)
        {
            Console.WriteLine(przemowa);
        }

        protected override void slabeMocneStrony()
        {
            Console.Write("\nSłabe strony to:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ogromne Ego, gotowi uwierzyć w byle bzdurę\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nMocne strony to:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Dobrze im idzie wytwarzanie narzędzi, od młotków po rakiety balistyczne \n\n");
            Console.ResetColor();
        }

    }
    
}
