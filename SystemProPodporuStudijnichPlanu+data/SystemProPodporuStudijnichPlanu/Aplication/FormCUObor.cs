using System;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUObor : Form
    {
        public string Rok
        {
            get => tb_rok.Text;
            set => tb_rok.Text = value;
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public string Nazev
        {
            get => tb_nazev.Text;
            set => tb_nazev.Text = value;
        }
        public string Id
        {
            get => tb_id.Text;
            set => tb_id.Text = value;
        }
        public int Pp
        {
            get => (int)nud_p.Value;
            set => nud_p.Value = value;
        }
        public int Pvp
        {
            get => (int)nud_pv.Value;
            set => nud_pv.Value = value;
        }
        public int Vp
        {
            get => (int)nud_v.Value;
            set => nud_v.Value = value;
        }
        public int Vs
        {
            get => (int)nud_vs.Value;
            set => nud_vs.Value = value;
        }
        public string Praxe
        {
            get => rtb_praxe.Text;
            set => rtb_praxe.Text = value;
        }
        public FormCUObor()
        {
            InitializeComponent();
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_nazev.Text == "" || tb_zkr.Text == "")
                MessageBox.Show("Musíte zadat název i zkratku katedry", "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}