﻿using System;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        public FormCRUDmidstage()
        {
            InitializeComponent();
        }

        private void Bt_novy_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
                NewGarant();
            if (rb_predmet.Checked == true)
                NewPredmet();
            if (rb_obor.Checked == true)
                NewObor();
            if (rb_katedra.Checked == true)
                NewKatedra();
        }
        private void NewGarant()
        {
            FormCUGarant g = new FormCUGarant();
            DialogResult potvrzeni = g.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                DataCrud x = new DataCrud();
                try
                {
                    x.InsertGarant(new Garant(g.Jmeno,
                                              g.Email,
                                              g.Kat,
                                              g.Tel,
                                              g.Konz));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void NewPredmet()
        {
            FormCUPredmet p = new FormCUPredmet();
            DialogResult potvrzeni = p.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                DataCrud x = new DataCrud();
                try
                {
                    x.InsertPredmet(new Predmet(p.Nazev,
                                                p.Zkr,
                                                p.Kredit,
                                                p.Obor,
                                                p.Garant,
                                                p.Semestr,
                                                p.Orig,
                                                p.Povinnost,
                                                p.Prednaska,
                                                p.Cv,
                                                p.Cvk,
                                                p.Lab,
                                                p.Jazyk,
                                                p.Zakonceni));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void NewObor()
        {
            FormCUObor o = new FormCUObor();
            DialogResult potvrzeni = o.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                DataCrud x = new DataCrud();
                DataAccess check = new DataAccess();
                check.CheckExistObor(o.Rok, out int test);
                try
                {
                    x.InsertObor(new Obor(o.Zkr,
                                          o.Nazev,
                                          o.Rok,
                                          o.Pp,
                                          o.Pvp,
                                          o.Vp,
                                          o.Vs,
                                          o.Praxe));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void NewKatedra()
        {
            FormCUKatedra k = new FormCUKatedra();
            DialogResult potvrzeni = k.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                DataCrud x = new DataCrud();
                DataAccess check = new DataAccess();
                try
                {
                    x.InsertKat(k.Zkr,
                                k.Nazev);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void Bt_close_Click(object sender, EventArgs e) => Close();
    }
}
