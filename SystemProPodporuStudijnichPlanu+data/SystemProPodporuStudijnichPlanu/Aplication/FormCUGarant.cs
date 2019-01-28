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
    public partial class FormCUGarant : Form
    {
        public FormCUGarant()
        {
            InitializeComponent();
        }
        public string Id
        {
            get => tb_id.Text;
            set => tb_id.Text = value;
        }
        public string Jmeno
        {
            get => tb_jm.Text;
            set => tb_jm.Text = value;
        }
        public string Email
        {
            get => tb_email.Text;
            set => tb_email.Text = value;
        }
        public string Tel
        {
            get => tb_tel.Text;
            set => tb_tel.Text = value;
        }
        public string Konz
        {
            get => tb_konz.Text;
            set => tb_konz.Text = value;
        }
        public string Kat
        {
            get => cmb_katedra.SelectedItem.ToString();
            set => cmb_katedra.SelectedItem = value;
        }

        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
