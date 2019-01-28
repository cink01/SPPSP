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
    public partial class FormCUPredmet : Form
    {
        public FormCUPredmet()
        {
            InitializeComponent();
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
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public string Orig
        {
            get => tb_orig.Text;
            set => tb_orig.Text = value;
        }
        public string Popis
        {
            get => rtb_popis.Text;
            set => rtb_popis.Text = value;
        }
        public int Kredit
        {
            get => (int)nud_kredit.Value;
            set => nud_kredit.Value = value;
        }
        public int Semestr
        {
            get => (int)nud_semestr.Value;
            set => nud_semestr.Value = value;
        }
        public int Prednaska
        {
            get => (int)nud_p.Value;
            set => nud_p.Value = value;
        }
        public int Cv 
        {
            get => (int)nud_cv.Value;
            set => nud_cv.Value = value;
        }
        public int Cvk
        {
            get => (int)nud_cvk.Value;
            set => nud_cvk.Value = value;
        }
        public int Lab 
        {
            get => (int)nud_lab.Value;
            set => nud_lab.Value = value;
        }
        public string Zakonceni
        {
            get => cb_zakončení.SelectedItem;
            set => cb_.SelectedItem = value;
        }
        public string Povinnost 
        {
            get => cb_povinnost.SelectedItem;
            set => cb_povinnost.SelectedItem = value;
        }
        public int Obor 
        {
            get => cb_.SelectedItem.Value;
            set => cb_.SelectedItem.Value = value;
        }
        public string Garant
        {
            get => cb_garant.SelectedItem;
            set => cb_garant.SelectedItem = value;
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lb_kredity_Click(object sender, EventArgs e)
        {

        }

        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
