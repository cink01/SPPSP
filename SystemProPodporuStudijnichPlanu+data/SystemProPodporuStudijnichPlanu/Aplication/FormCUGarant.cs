using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUGarant : Form
    {
        Filling fill = new Filling();
        List<Katedra> katedras = new List<Katedra>();
        public FormCUGarant()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            katedras = da.GetFullKatedra();
            fill.NaplnComboBox<Katedra>(cmb_katedra, katedras);
        }
        public Garant G
        {
            get
            {
                return new Garant(Convert.ToInt32(tb_id.Text), tb_jm.Text, tb_email.Text, cmb_katedra.SelectedItem.ToString(), tb_tel.Text, tb_konz.Text);
        	}
            set
            {
                G = value;
                Id = G.Id_v.ToString();
                Jmeno = G.Jmeno_v;
                Email = G.Email_V;
                Tel = G.Tel_v;
                Konz = G.Konz_v;
                Kat = G.Id_k;
            }
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
        public int Kat
        {
            get
            {
                foreach (Katedra k in katedras)
                    if (k.Naz_k == cmb_katedra.SelectedIndex.ToString())
                        return k.Id_k;
                return 0;
            }

            set
            {
                foreach(Katedra k in katedras)
                    if(k.Id_k==value)
                        cmb_katedra.SelectedIndex = cmb_katedra.FindStringExact(k.Naz_k);
            }
        }

        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Kat_Hledani(object sender, EventArgs e)
        {
            fill.NajdiVComboBoxu<Katedra>(cmb_katedra, katedras);
        }
    }
}
