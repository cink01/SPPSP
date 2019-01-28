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
            else
            {
                DataCrud x = new DataCrud();
                DataAccess a = new DataAccess();
                a.CheckExistObor(tb_nazev.Text, out int i);
                if (i == 0)
                {
                    try
                    {
                        x.InsertObor(new Obor(tb_zkr.Text,
                                              tb_nazev.Text,
                                              tb_rok.Text,
                                              Convert.ToInt32(nud_p.Value),
                                              Convert.ToInt32(nud_pv.Value),
                                              Convert.ToInt32(nud_v.Value),
                                              Convert.ToInt32(nud_vs.Value),
                                              rtb_praxe.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Zadaná katedra již existuje!", "Existence záznamu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
