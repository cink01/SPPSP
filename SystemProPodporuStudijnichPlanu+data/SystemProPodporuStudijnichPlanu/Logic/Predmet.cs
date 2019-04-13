using System;

namespace SystemProPodporuStudijnichPlanu
{
    public class Predmet//přepravka
    {
        public int Id_predmet { get; set; }
        public string Name_predmet { get; set; }
        public string Zkr_predmet { get; set; }
        public int Kredit_predmet { get; set; }
        public int Id_obor { get; set; }
        public int Id_v { get; set; }
        public int Semestr_predmet { get; set; }
        public int Id_orig { get; set; }
        public string Povinnost { get; set; }
        public int Prednaska { get; set; }
        public int Cviceni { get; set; }
        public int Kombi { get; set; }
        public int Lab { get; set; }
        public string Jazyk { get; set; }
        public string Zakonceni { get; set; }
        public string Popis { get; set; }
        public int Prerekvizita { get; set; }
        public Predmet()/*prazdný constructor*/{ }

        public Predmet(string name_predmet, string zkr_predmet, string kredit_predmet, string obor, string garant, string semestr_predmet, string id_orig, string povinnost, string prednaska, string cviceni, string kombi, string lab, string jazyk, string zakonceni)
        //constructor bez umělého klíče id_predmet jako přepravka pro vkladaní do db hleda cizí klíče takže funkce neptřebuje
        {
            DataAccess da = new DataAccess();
            Name_predmet = name_predmet;
            Zkr_predmet = zkr_predmet;
            Kredit_predmet = Convert.ToInt32(kredit_predmet);
            Id_obor = da.GetOborId(obor);
            Id_v = da.GetGarantId(garant);
            Jazyk = jazyk;
            Zakonceni = zakonceni;
            if (semestr_predmet == "")
                Semestr_predmet = 0;
            else
                Semestr_predmet = Convert.ToInt32(semestr_predmet);
            Id_orig = Convert.ToInt32(id_orig);
            Povinnost = povinnost;
            if (prednaska == "")
                Prednaska = 0;
            else
                Prednaska = Convert.ToInt32(prednaska);
            if (cviceni == "")
                Cviceni = 0;
            else
                Cviceni = Convert.ToInt32(cviceni);
            if (kombi == "")
                Kombi = 0;
            else
                Kombi = Convert.ToInt32(kombi);
            if (lab == "")
                Lab = 0;
            else
                Lab = Convert.ToInt32(lab);
        }

        public Predmet(int id_predmet, string name_predmet, string zkr_predmet, int kredit_predmet, int id_obor, int id_v, int semestr_predmet, int id_orig, string povinnost, int prednaska, int cviceni, int kombi, int lab, string jazyk, string zakonceni, string popis,int prerekvizita)
        //full constructor
        {
            Id_predmet = id_predmet;
            Name_predmet = name_predmet;
            Zkr_predmet = zkr_predmet;
            Kredit_predmet = kredit_predmet;
            Id_obor = id_obor;
            Id_v = id_v;
            Semestr_predmet = semestr_predmet;
            Id_orig = id_orig;
            Povinnost = povinnost;
            Prednaska = prednaska;
            Cviceni = cviceni;
            Kombi = kombi;
            Lab = lab;
            Jazyk = jazyk;
            Zakonceni = zakonceni;
            Popis = popis;
            Prerekvizita = prerekvizita;
        }
        public Predmet(string name_predmet,string popis, string obor)
        //Konstruktor pro popis
        {
            DataAccess da = new DataAccess();
            Id_predmet = da.GetPredmetId(name_predmet, obor);
            Popis = popis;
        }
        public override string ToString() => Name_predmet;
        public int ToInt() => Id_predmet;
        public string FullInfo => $"{Name_predmet} - {Zkr_predmet} - {Id_predmet} - {Semestr_predmet} - {Kredit_predmet} ";
        public string NazInfo => $"{Name_predmet} - {Zkr_predmet}";
        public string PredmetPopis => $"{Name_predmet}\nNěco:{Kredit_predmet}\nPopis:{Popis}";
    }
}