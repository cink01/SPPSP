﻿namespace SystemProPodporuStudijnichPlanu.Logic
{
    public class Zaznam
    {
        public Zaznam(string zkr_zaznam, int id_obor, int pocetSem)
        //constructor bez id
        {
            Zkr_zaznam = zkr_zaznam;
            Id_obor = id_obor;
            PocetSem = pocetSem;
        }

        public Zaznam(int id_zaznam, string zkr_zaznam, int id_obor, int pocetSem)
        //full constructor
        {
            Id_zaznam = id_zaznam;
            Zkr_zaznam = zkr_zaznam;
            Id_obor = id_obor;
            PocetSem = pocetSem;
        }

        public int Id_zaznam { get; set; }
        public string Zkr_zaznam { get; set; }
        public int Id_obor { get; set; }
        public int PocetSem { get; set; }

        public override string ToString()
        {
            return Zkr_zaznam;
        }
    }
}
