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
        public string Nazev
        {
            get => tb_název.Text;
            set => tb_název.Text = value;
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_název.Text == "" || tb_zkr.Text == "")
                MessageBox.Show("Musíte zadat název i zkratku katedry", "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}