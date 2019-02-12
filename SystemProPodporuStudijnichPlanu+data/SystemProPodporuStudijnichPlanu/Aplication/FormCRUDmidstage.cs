﻿using System;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;
using System.Collections.Generic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        List<Katedra> katedras = new List<Katedra>();
        List<Obor> obors = new List<Obor>();
        List<Garant> garants = new List<Garant>();
        List<Predmet> predmets = new List<Predmet>();
        public StringComparison Comp { get; set; } = StringComparison.OrdinalIgnoreCase;
        public FormCRUDmidstage()
        {
            InitializeComponent();
        }
        private void FormCRUDmidstage_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            katedras = da.GetFullKatedra();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            predmets = da.GetFullPredmet();
            da.FillCbPredmetFList(cb_pre, predmets);
            da.FillCbGarantFList(cb_garant, garants);
            da.FillCbOborFList(cb_obo, obors);
            da.FillCbKatFList(cb_kat, katedras);
        }
        private void Bt_novy_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                NewGarant();
            }
            if (rb_predmet.Checked == true)
            {
                NewPredmet();
            }
            if (rb_obor.Checked == true)
            {
                NewObor();
            }

            if (rb_katedra.Checked == true)
            {
                NewKatedra();
            }
        }
        private void NewGarant()
        {
            using (FormCUGarant g = new FormCUGarant())
            {
                g.Text = "Založit nového garanta";
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
                }
            }
        }
        private void NewPredmet()
        {
            using (FormCUPredmet p = new FormCUPredmet())
            {
                p.Text = "Založit nový předmět";
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
                }
            }
        }
        private void NewObor()
        {
            using (FormCUObor o = new FormCUObor())
            {
                o.Text = "Založit nový obor";
                DialogResult potvrzeni = o.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
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
                }
            }
        }
        private void NewKatedra()
        {
            using (FormCUKatedra k = new FormCUKatedra())
            {
                k.Text = "Založit novou katedru";
                DialogResult potvrzeni = k.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
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
                }
            }
        }
        private void Bt_close_Click(object sender, EventArgs e) => Close();
        private void Tb_katedraN_TextChanged(object sender, EventArgs e)
        {
            cb_kat.Items.Clear();
            cb_kat.Text = "Nalezené katedry";
            foreach (Katedra k in katedras)
                if (k.Naz_k.IndexOf(tb_katedraN.Text, Comp) >= 0)
                    cb_kat.Items.Add(k.Naz_k);
        }
        private void Tb_oborN_TextChanged(object sender, EventArgs e)
        {
            cb_obo.Items.Clear();
            cb_obo.Text = "Nalezené obory";
            foreach (Obor o in obors)
                if (o.Name_obor.IndexOf(tb_oborN.Text, Comp) >= 0)
                    cb_obo.Items.Add(o.Name_obor);
        }
        private void Tb_predmetN_TextChanged(object sender, EventArgs e)//pri změně oboru se přepiše list a ten se pak bude kontrolovat podle nazvu 
        {
            cb_pre.Items.Clear();
            foreach (Predmet p in predmets)
                if (p.Name_predmet.IndexOf(tb_predmetN.Text, Comp) >= 0)
                    cb_pre.Items.Add(p.Name_predmet);
        }
        private void Cb_garant_Hledani(object sender, EventArgs e)//garant funguje
        {
            cb_garant.Items.Clear();
            foreach (Garant g in garants)
                if (g.Jmeno_v.IndexOf(cb_garant.Text, Comp) >= 0)
                    cb_garant.Items.Add(g.Jmeno_v);
        }
        private void Cb_predmet_Hledani(object sender, EventArgs e)//pred nefunguje
        {
            if (cb_pre.Text != "")
            {
                cb_pre.Items.Clear();
                foreach (Predmet p in predmets)
                {
                    if (p.Name_predmet.IndexOf(cb_pre.Text, Comp) >= 0)
                    {
                        cb_garant.Items.Add(p.Name_predmet);
                    }
                }
            }
        }
        private void Cb_obor_Hledani(object sender, EventArgs e) //obor funguje
        {
            cb_obo.Items.Clear();
            foreach (Obor o in obors)
            {
                if (o.Name_obor.IndexOf(cb_obo.Text, Comp) >= 0)
                {
                    cb_obo.Items.Add(o.Name_obor);
                }
            }
        }

        private void Cb_katedra_Hledani(object sender, EventArgs e)//kat nefunguje
        {
            if (cb_kat.Text != "")
            {
                cb_kat.Items.Clear();
                foreach (Katedra k in katedras)
                { 
                    if (k.Naz_k.IndexOf(cb_kat.Text, Comp) >= 0)
                    { 
                        cb_garant.Items.Add(k.Naz_k);
                    }
                }
            }
        }
    }
}