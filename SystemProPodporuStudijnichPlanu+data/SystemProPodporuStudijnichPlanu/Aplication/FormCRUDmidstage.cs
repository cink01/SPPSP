using System;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
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
            FormCUPredmet p = new FormCUPredmet();
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
        private void NewObor()
        {
            FormCUObor o = new FormCUObor();
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
        private void NewKatedra()
        {
            FormCUKatedra k = new FormCUKatedra();
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
        private void Bt_close_Click(object sender, EventArgs e) => Close();
    }
}
