using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    public partial class VypisPopisPredmet : UserControl
    {
        public VypisPopisPredmet()
        {
            InitializeComponent();
        }
        public Predmet P { get; set; }
        public string Zkr
        {
            get => tb_zkratka.Text;
            set => tb_zkratka.Text = value;
        }
        public string Popis
        {
            get => rtb_popis.Text;
            set => rtb_popis.Text = value;
        }
        public string Kredit
        {
            get => tb_kredity.Text;
            set => tb_kredity.Text = value;
        }
        public string Povinnost
        {
            get => tb_povinn.Text;
            set => tb_povinn.Text = value;
        }
        public string Zakončení
        {
            get => tb_zakonc.Text;
            set => tb_zakonc.Text = value;
        }
        public string Prerekvizita

        {
            get => tb_prerek.Text;
            set => tb_prerek.Text = value;
        }
        public string Garant
        {
            get => tb_garant.Text;
            set => tb_garant.Text = value;
        }
        public string Jazyk
        {
            get => tb_jazyk.Text;
            set => tb_jazyk.Text = value;
        }
        public string Prednaska
        {
            get => tb_prednaska.Text;
            set => tb_prednaska.Text = value;
        }
        public string Cviceni
        {
            get => tb_cviceni.Text;
            set => tb_cviceni.Text = value;
        }
        public string Kombi
        {
            get => tb_kombi.Text;
            set => tb_kombi.Text = value;
        }
        public string Lab
        {
            get => tb_laborator.Text;
            set => tb_laborator.Text = value;
        }
        public string Semestr
        {
            get => tb_semestr.Text;
            set => tb_semestr.Text = value;
        }
    }
}
