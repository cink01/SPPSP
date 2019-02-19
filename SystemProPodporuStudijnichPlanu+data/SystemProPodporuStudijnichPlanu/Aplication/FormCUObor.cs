using System;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUObor : Form
    {
        public Obor O
        {
            get
            {
                return new Obor(Id, tb_zkr.Text, tb_nazev.Text, tb_rok.Text, Convert.ToInt32(nud_p.Value), Convert.ToInt32(nud_pv.Value), Convert.ToInt32(nud_v.Value), Convert.ToInt32(nud_vs.Value), rtb_praxe.Text);
            }
            set
            {
                O = value;
                tb_id.Text = O.Id_obor.ToString();
                tb_zkr.Text = O.Zkr_obor;
                tb_nazev.Text = O.Name_obor;
                tb_rok.Text = O.Rok_obor;
                nud_p.Value = O.P_obor;
                nud_pv.Value = O.Pv_obor;
                nud_v.Value = O.V_obor;
                nud_vs.Value = O.Vs_obor;
                rtb_praxe.Text = O.Praxe;
            }
        }
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
        public int Id
        {
            get
            {
                if (tb_id.Text == "")
                    return -1;
                else
                    return Convert.ToInt32(tb_id.Text);
            }
            set => tb_id.Text = value.ToString();
        }
        public int P
        {
            get => (int)nud_p.Value;
            set => nud_p.Value = value;
        }
        public int Pv
        {
            get => (int)nud_pv.Value;
            set => nud_pv.Value = value;
        }
        public int V
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