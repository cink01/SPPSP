namespace SystemProPodporuStudijnichPlanu
{
    public class Predmet
    {
        private int idPredmet;
        private string zkratkaPredmet;
        private string nazevPredmet;
        private int kreditPredmet;
        private int semestrPredmet;
        private string popisPredmet;

        /* public Predmet()
         {
             this.idPredmet = 0;
             this.zkratkaPredmet = "-1";
             this.nazevPredmet = "-1";
             this.kreditPredmet = 0;
             this.semestrPredmet = 0;
         }*/

        public Predmet(int idPredmet, string zkratkaPredmet, string nazevPredmet, int kreditPredmet, int semestrPredmet, string popisPredmet)
        {
            this.idPredmet = idPredmet;
            this.zkratkaPredmet = zkratkaPredmet;
            this.nazevPredmet = nazevPredmet;
            this.kreditPredmet = kreditPredmet;
            this.PopisPredmet = popisPredmet;
            this.semestrPredmet = semestrPredmet;
        }

        public string NazevPredmet { get => nazevPredmet; set => nazevPredmet = value; }
        public string ZkratkaPredmet { get => zkratkaPredmet; set => zkratkaPredmet = value; }
        public int IdPredmet { get => idPredmet; set => idPredmet = value; }
        public int KreditPredmet { get => kreditPredmet; set => kreditPredmet = value; }
        public int SemestrPredmet { get => semestrPredmet; set => semestrPredmet = value; }
        public string PopisPredmet { get => popisPredmet; set => popisPredmet = value; }

        public override string ToString()
        {
            return zkratkaPredmet + " - " + nazevPredmet + " - " + "Kredity: " + kreditPredmet;
        }

        public string FullInfo
        {
            get
            {
                return $"{zkratkaPredmet} - {nazevPredmet} - {idPredmet} - {SemestrPredmet} - {kreditPredmet} ";
            }
        }

        public string KrInfo
        {
            get
            {
                return $"{kreditPredmet} ";
            }
        }

        public string SemInfo
        {
            get
            {
                return $"{SemestrPredmet}";
            }
        }

        public string NazInfo
        {
            get
            {
                return $"{zkratkaPredmet} - {nazevPredmet}";
            }
        }
    }/*

    public class FullPredmet : Predmet
    {
        string popisPredmet;

        public FullPredmet(string popisPredmet,int idPredmet, string zkratkaPredmet, string nazevPredmet, int kreditPredmet, int semestrPredmet)
            : base(idPredmet, zkratkaPredmet, nazevPredmet, kreditPredmet, semestrPredmet)
        {
            this.PopisPredmet = popisPredmet;
        }

        public string PopisPredmet { get => popisPredmet; set => popisPredmet = value; }
    }*/
}