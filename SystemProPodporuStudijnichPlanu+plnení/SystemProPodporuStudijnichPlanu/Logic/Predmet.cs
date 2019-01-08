namespace SystemProPodporuStudijnichPlanu
{
    public class Predmet
    {
        private int id_predmet;
        private string name_predmet;
        private string zkr_predmet;
        private int kredit_predmet;
        private int id_obor;
        private int semestr_predmet;

        public Predmet()
        {
        }



        /* public Predmet()
         {
             this.id_predmet = 0;
             this.zkratkaPredmet = "-1";
             this.nazevPredmet = "-1";
             this.kreditPredmet = 0;
             this.semestrPredmet = 0;
         }*/

        public Predmet(int idPredmet, string nazev, string zkratka, int kredity, int id_obor,int semestr )
        {
            this.id_predmet = idPredmet;
            this.name_predmet = nazev;
            this.zkr_predmet = zkratka;
            this.kredit_predmet = kredity;
            this.id_obor = id_obor;
            this.semestr_predmet = semestr;
        }

        public string Zkr_predmet { get => zkr_predmet; set => zkr_predmet = value; }
        public string Name_predmet { get => name_predmet; set => name_predmet = value; }
        public int Id_predmet { get => id_predmet; set => id_predmet = value; }
        public int Kredit_predmet { get => kredit_predmet; set => kredit_predmet = value; }
        public int Semestr_predmet { get => semestr_predmet; set => semestr_predmet = value; }
        public int Id_obor { get => id_obor; set => id_obor = value; }

        public override string ToString()
        {
            return name_predmet + " - " + zkr_predmet + " - " + "Kredity: " + kredit_predmet;
        }

        public string FullInfo
        {
            get
            {
                return $"{Name_predmet} - {Zkr_predmet} - {Id_predmet} - {Semestr_predmet} - {Kredit_predmet} ";
            }
        }

        public string KrInfo
        {
            get
            {
                return $"{Kredit_predmet} ";
            }
        }

        public string SemInfo
        {
            get
            {
                return $"{Semestr_predmet}";
            }
        }

        public string NazInfo
        {
            get
            {
                return $"{Name_predmet} - {Zkr_predmet}";
            }
        }
    }/*

    public class FullPredmet : Predmet
    {
        string popisPredmet;

        public FullPredmet(string popisPredmet,int id_predmet, string zkratkaPredmet, string nazevPredmet, int kreditPredmet, int semestrPredmet)
            : base(id_predmet, zkratkaPredmet, nazevPredmet, kreditPredmet, id_obor)
        {
            this.PopisPredmet = popisPredmet;
        }

        public string PopisPredmet { get => popisPredmet; set => popisPredmet = value; }
    }*/
}