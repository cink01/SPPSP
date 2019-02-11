using System;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;
using System.Collections.Generic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        public List<Katedra> kat = new List<Katedra>();
        public List<Obor> obo = new List<Obor>();
        public List<Garant> gar = new List<Garant>();
        public List<Predmet> pre = new List<Predmet>();
        public StringComparison Comp { get; set; } = StringComparison.OrdinalIgnoreCase;
        public FormCRUDmidstage()
        {
            InitializeComponent();
            DataAccess a = new DataAccess();
            a.FillOborCB(cb_obor);
            a.FillKatedraCB(cb_katedra);
            a.FillGarantCB(cb_garant);
        }
        private void Bt_novy_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                //  bt_novy;
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
        private void FormCRUDmidstage_Load(object sender, EventArgs e)
        {

        }
        //vraceni listu a plnění datasetu a mazani z nich
        private void Tb_katedraN_TextChanged(object sender, EventArgs e)
        {
            cb_katedra.Items.Clear();
            //chb_exist.Checked = false;
            cb_katedra.Text = "Nalezené katedry";
            foreach (Katedra k in kat)
            {
                if (k.Naz_k.IndexOf(tb_katedraN.Text, Comp) >= 0)
                {
                    cb_katedra.Items.Add(k.Naz_k);
                    //  chb_exist.Checked = true;
                }
            }
        }
        private void Tb_oborN_TextChanged(object sender, EventArgs e)
        {
            cb_obor.Items.Clear();
            //chb_exist.Checked = false;
            cb_obor.Text = "Nalezené obory";
            foreach (Obor o in obo)
            {
                if (o.Name_obor.IndexOf(tb_oborN.Text, Comp) >= 0)
                {
                    cb_obor.Items.Add(o.Name_obor);
                    //  chb_exist.Checked = true;
                }
            }
        }
        private void Tb_garantN_TextChanged(object sender, EventArgs e)
        {
            cb_garant.Items.Clear();
            //chb_exist.Checked = false;
            cb_garant.Text = "Nalezení garanti";
            foreach (Garant g in gar)
            {
                if (g.Jmeno_v.IndexOf(tb_garantN.Text, Comp) >= 0)
                {
                    cb_garant.Items.Add(g.Jmeno_v);
                    //  chb_exist.Checked = true;
                }
            }
        }
        private void Tb_predmetN_TextChanged(object sender, EventArgs e)
        {
            cb_predmet.Items.Clear();
            //chb_exist.Checked = false;
            cb_predmet.Text = "Nalezené předměty";
            foreach (Predmet p in pre)
            {
                if (p.Name_predmet.IndexOf(tb_predmetN.Text, Comp) >= 0)
                {
                    cb_predmet.Items.Add(p.Name_predmet);
                    //  chb_exist.Checked = true;
                }
            }
        }
    }
}