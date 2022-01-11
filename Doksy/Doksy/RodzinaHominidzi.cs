using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    abstract class RodzinaHominidzi
    {
        static protected string rodzina = "Hominidzi";
        //Rodzina - (Hominidzi) człowiekowate -> Rodzaj (Genera) Homo  -> Gatunek Sapiens (GeneraHomoSapiens)
        //                                                             -> Gatunek Neandertalis
        //                                                             -> Gatunek ............
        //                                                             -> Gatunek ............
        // Australopitecus 2,5m lat==> Rodzina - (Hominidzi) człowiekowate
        public abstract void mowa();
    }
}
