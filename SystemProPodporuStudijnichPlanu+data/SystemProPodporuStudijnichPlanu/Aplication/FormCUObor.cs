using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Gb_obor_Enter(object sender, EventArgs e)
        {

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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Tb_rok_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_email_Click(object sender, EventArgs e)
        {

        }

        private void L_zkr_Click(object sender, EventArgs e)
        {

        }

        private void L_id_Click(object sender, EventArgs e)
        {

        }

        private void Tb_zkr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_nazev_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Nud_p_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_pv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_vs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nud_v_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
