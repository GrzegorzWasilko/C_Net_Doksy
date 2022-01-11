using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class RodzajCzlowiek: RodzinaHominidzi // łac.genus-homo
    {
        private string ost_przodek;
        public RodzajCzlowiek()
        {
            ost_przodek = " Australopitecus";
        }
        //private int pojawienie = 2500000;
        protected string gatunek;
        protected string przydomek;
        protected string end;
        protected int pojawienie;
        protected string zdanie;
        protected string imie;
        public string Imie
        {
            get
            {
                return imie + " z gatunku " + gatunek;
            }
            set
            {
                imie = value;
            }
        }

        public override void mowa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(zdanie);
            Console.ResetColor();
        }

        protected void wprowadzenie()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ================================================ " );
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("|"); 
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write (" Tekst żółty  to cechy indywidualne gatunku      "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("|\n");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("|"); 
            Console.ForegroundColor = ConsoleColor.Green; Console.Write(" Tekst zielony to cechy wspólne wszystkich ludzi "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("|\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ================================================ ");
            Console.ResetColor();
        }
        protected void WspolneCechy()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nNależą do rodziny {rodzina}  ");
            Console.WriteLine($"ich ostatni przodek to: {ost_przodek.ToUpper()} \n\n");
            Console.ResetColor();

        }
        protected virtual void slabeMocneStrony()
        {
            Console.Write("\nSłabe strony to:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(".........funkcja virtual z klasy bazowej........\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nMocne strony to:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($".........funkcja virtual z klasy bazowej......\n\n");
            Console.ResetColor();
        }

        public void Opis()
        {
            wprowadzenie();
            Console.WriteLine($"osobnik {Imie} \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"pochodzi z gatunku {gatunek.ToUpper()}");
            Console.WriteLine($"gatunek ten pojawił sie {pojawienie} lat temu" + end);
            Console.WriteLine($"ich przydomek to: {przydomek} ");
            slabeMocneStrony();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"ich mowa wygląda tak:");
            mowa();
            Console.ResetColor();

            WspolneCechy();
        }
    }

}
