using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class BAlkezes
    {
        string nev;
        string palyaralepes;
        string utolsoPalya;
        int suly;
        int magassag;

        public BAlkezes(string nev, string palyaralepes, string utolsoPalya, int suly, int magassag)
        {
            this.nev = nev;
            this.palyaralepes = palyaralepes;
            this.utolsoPalya = utolsoPalya;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Palyaralepes { get => palyaralepes; set => palyaralepes = value; }
        public string UtolsoPalya { get => utolsoPalya; set => utolsoPalya = value; }
        public int Suly { get => suly; set => suly = value; }
        public int Magassag { get => magassag; set => magassag = value; }
    }
}
