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
            FillOborCB();
            FillKatedraCB();
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
        private void FillOborCB()
        {
            DataAccess A = new DataAccess();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT rok_obor,id_obor FROM obor";
                    SqlDataAdapter da = new SqlDataAdapter(query, A.GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Obor");
                    cb_obor.DisplayMember = "rok_obor";
                    cb_obor.ValueMember = "id_obor";
                    cb_obor.DataSource = ds.Tables["Obor"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!"+ex);
                }
            }
        }
        private void FillKatedraCB()
        {
            DataAccess A = new DataAccess();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT id_k,naz_k FROM katedra";
                    SqlDataAdapter da = new SqlDataAdapter(query, A.GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Katedra");
                    cb_katedra.DisplayMember = "naz_k";
                    cb_katedra.ValueMember = "id_k";
                    cb_katedra.DataSource = ds.Tables["Katedra"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex);
                }
            }
        }
    }
}
