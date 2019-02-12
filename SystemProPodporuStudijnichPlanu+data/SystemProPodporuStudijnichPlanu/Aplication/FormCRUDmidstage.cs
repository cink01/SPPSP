using System;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;
using System.Collections.Generic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        public List<Katedra> katedras = new List<Katedra>();
        public List<Obor> obors = new List<Obor>();
        public List<Garant> garants = new List<Garant>();
        public List<Predmet> predmets = new List<Predmet>();
        public StringComparison Comp { get; set; } = StringComparison.OrdinalIgnoreCase;
        public FormCRUDmidstage()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            katedras = da.GetFullKatedra();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            predmets = da.GetFullPredmet();
            da.FillCbGarantFList(cb_garant,garants);
            da.FillCbKatFList(cb_katedra, katedras);
            da.FillCbPredmetFList(cb_predmet, predmets);
            da.FillCbOborFList(cb_obor, obors);
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
            foreach (Katedra k in katedras)
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
            foreach (Obor o in obors)
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
            foreach (Garant g in garants)
            {
                if (g.Jmeno_v.IndexOf(tb_garantN.Text, Comp) >= 0)
                {
                    cb_garant.Items.Add(g.Jmeno_v);
                    //  chb_exist.Checked = true;
                }
            }
        }
        private void Tb_predmetN_TextChanged(object sender, EventArgs e)//pri změně oboru se přepiše list a ten se pak bude kontrolovat podle nazvu 
        {
            cb_predmet.Items.Clear();
            //chb_exist.Checked = false;
            cb_predmet.Text = "Nalezené předměty";
            foreach (Predmet p in predmets)
            {
                if (p.Name_predmet.IndexOf(tb_predmetN.Text, Comp) >= 0)
                {
                    cb_predmet.Items.Add(p.Name_predmet);
                }
            }
        }
    }
}