using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    public partial class VypisObor : UserControl
    {
        public string Rok
        {
            get => tb_rok.Text;
            set => tb_rok.Text = value;
        }
        public string Zkr
        {
            get => tb_zkratka.Text;
            set => tb_zkratka.Text = value;
        }
        public string P
        {
            get => tb_p.Text;
            set => tb_p.Text = value;
        }
        public string Pv
        {
            get => tb_pv.Text;
            set => tb_pv.Text = value;
        }
        public string V
        {
            get => tb_v.Text;
            set => tb_v.Text = value;
        }
        public string Vs
        {
            get => tb_s.Text;
            set => tb_s.Text = value;
        }
        public string Praxe
        {
            get => rtb_praxe.Text;
            set => rtb_praxe.Text = value;
        }
        public string Zaver
        {
            get => rtb_zaver.Text;
            set => rtb_zaver.Text = value;
        }
        public VypisObor()
        {
            InitializeComponent();
        }
    }
}