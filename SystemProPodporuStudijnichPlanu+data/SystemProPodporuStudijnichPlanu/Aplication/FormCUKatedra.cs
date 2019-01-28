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
    public partial class FormCUKatedra : Form
    {
        public FormCUKatedra()
        {
            InitializeComponent();
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_název.Text == "" || tb_zkr.Text == "")
                MessageBox.Show("Musíte zadat název i zkratku katedry", "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataCrud x = new DataCrud();
                DataAccess a = new DataAccess();
                a.CheckExistKatedra(tb_název.Text, out int i);
                if (i == 0)
                {
                    try
                    {
                        x.InsertKat(tb_zkr.Text, tb_název.Text);
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
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}