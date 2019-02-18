using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    public partial class VypisKatedra : UserControl
    {
        public string Naz
        {
            get => tb_nazev.Text;
            set => tb_nazev.Text = value;
        }
        public string Zkr
        {
            get => tb_zkratka.Text;
            set => tb_zkratka.Text = value;
        }
        public string PocG
        {
            get => tb_pocG.Text;
            set => tb_pocG.Text = value;
        }
        public VypisKatedra()
        {
            InitializeComponent();
        }
    }
}
