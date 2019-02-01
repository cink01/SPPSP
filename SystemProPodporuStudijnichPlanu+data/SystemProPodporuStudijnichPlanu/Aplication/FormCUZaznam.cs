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
    public partial class FormCUZaznam : Form
    {
        public string Id
        {
            get => tb_id.Text;
            set => tb_id.Text = value;
        }
        public int Semestr
        {
            get => (int)nud_semestr.Value;
            set => nud_semestr.Value = Convert.ToDecimal(value);
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public string Obor
        {
            get
            {
                DataRowView DV = cmb_obor.SelectedItem as DataRowView;
                return DV.Row["rok_obor"].ToString();
            }
            set => cmb_obor.SelectedIndex = cmb_obor.FindStringExact(value);
        }
        public FormCUZaznam()
        {
            DataAccess a = new DataAccess();
            InitializeComponent();
            a.FillOborCB(cmb_obor);
        }

        private void FormCUZaznam_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tb_id.Text!="")
            {
                bt_info.Visible = true;
            }
        }

        private void Bt_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Změna oboru povede k smazání zadaných předmětů v semestrech.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
