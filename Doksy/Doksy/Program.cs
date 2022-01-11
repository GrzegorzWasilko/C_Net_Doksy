using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class Program
    {
        static void Main(string[] args)
        {
            GatunekSapiens osobnikSapiens = new GatunekSapiens();
            osobnikSapiens.Imie = "Ludź";
            //string zdanie = "no to, ten tego ";
           // osobnikSapiens.odezwij_sie(zdanie);
   

            GatunekNeanderthalensis osobnikNeandertal = new GatunekNeanderthalensis();
            osobnikNeandertal.Imie = "Ludź";

            GatunekDenisovensis osobnikDenisowianin = new GatunekDenisovensis();
            osobnikDenisowianin.Imie = "Ludź";

            //string i = Console.ReadLine();
    //##################################################################################
            Menu mainMenu = new Menu(new string[] {
                "Opis Sapiens",
                "Opis Neanderthalis",
                "opis Denisovensis",
                "Exit" });
            int decision;
    //##################################################################################
            do
            {
                decision = mainMenu.Open();
                if (decision == 0)
                {
                    Console.Clear();
                    osobnikSapiens.Opis();
                    Console.ReadKey();
                }
                else if (decision == 1)
                {
                    Console.Clear();
                    osobnikNeandertal.Opis();
                    Console.ReadKey();
                }
                else if (decision == 2)
                {
                    Console.Clear();
                    osobnikDenisowianin.Opis();
                    Console.ReadKey();
                }

            } while (decision != 3 && decision != -1);

    //##################################################################################

        }
    }
}
