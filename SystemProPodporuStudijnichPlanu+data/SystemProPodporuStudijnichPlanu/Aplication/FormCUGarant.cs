﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;
using System.Net.Mail;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUGarant : Form
    {
        private Filling fill = new Filling();
        private List<Katedra> katedras = new List<Katedra>();
        public FormCUGarant()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            errorProvider_EMAIL.SetIconAlignment(tb_email, ErrorIconAlignment.MiddleRight);
            errorProvider_EMAIL.SetIconPadding(tb_email, 2);
            errorProvider_EMAIL.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            katedras = da.GetFullKatedra();
            fill.NaplnComboBox<Katedra>(cmb_katedra, katedras);
        }
        public Garant G
        {
            get => new Garant(Id, Jmeno, Email, Tel, Konz, Kat);
            set
            {
                G = value;
                Id = G.Id_v;
                Jmeno = G.Jmeno_v;
                Email = G.Email_V;
                Tel = G.Tel_v;
                Konz = G.Konz_v;
                Kat = G.Id_k;
            }
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
                    if (k.Naz_k == cmb_katedra.SelectedItem.ToString())
                        return k.Id_k;
                return 0;
            }
            set
            {
                foreach (Katedra k in katedras)
                    if (k.Id_k == value)
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
        private bool ValidnidEmail(string email)
        {
            try
            {
                var adresa = new MailAddress(email);
                return adresa.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_jm.Text == "" || cmb_katedra.SelectedIndex == -1)
                MessageBox.Show(Properties.Resources.NeedforGar_MESSAGE, Properties.Resources.Chyba_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.DialogResult = DialogResult.OK;
        }

        private void Tb_email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider_EMAIL.Clear();
            if (ValidnidEmail(tb_email.Text)==false)
            {
                errorProvider_EMAIL.SetError(tb_email, "Email není ve správném formátu");
                e.Cancel = true;
            }
        }
    }
}