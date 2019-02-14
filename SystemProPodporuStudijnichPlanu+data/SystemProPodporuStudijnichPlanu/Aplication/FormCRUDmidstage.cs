using System;
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
            Filling fill = new Filling();
            DataAccess da = new DataAccess();
            katedras = da.GetFullKatedra();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            predmets = da.GetFullPredmet();
            fill.NaplnComboBox<Predmet>(cb_pre, predmets);
            fill.NaplnComboBox<Garant>(cb_garant, garants);
            fill.NaplnComboBox<Obor>(cb_obo, obors);
            fill.NaplnComboBox<Obor>(cmb_obo_pre, obors);
            fill.NaplnComboBox<Katedra>(cb_kat, katedras);
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
                                              o.P,
                                              o.Pv,
                                              o.V,
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
       /* private void Tb_oborN_TextChanged(object sender, EventArgs e)
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
          }*/
        private void Cb_garant_Hledani(object sender, EventArgs e)//garant funguje
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Garant>(cb_garant, garants);
        }
        private void Cb_predmet_Hledani(object sender, EventArgs e)//pred nefunguje
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Predmet>(cb_pre, predmets);
        }
        private void Cb_obor_Hledani(object sender, EventArgs e) //obor funguje
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cb_obo, obors);
        }

        private void Cb_katedra_Hledani(object sender, EventArgs e)//kat nefunguje
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Katedra>(cb_kat, katedras);
        }
        private void Cmb_obo_pre_Hledání(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cmb_obo_pre, obors);
        }
        private void Cmb_obo_pre_SelectedIndexChanged(object sender, EventArgs e)
        {
            predmets.Clear();
            DataAccess da = new DataAccess();
            Obor temp = (Obor)cmb_obo_pre.SelectedItem;
            predmets = da.GetPredmetFullByObor(temp.Id_obor);
            Filling fill = new Filling();
            fill.NaplnComboBox<Predmet>(cb_pre, predmets);
        }

        private void Bt_upravit_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                EditGarant();
            }
            if (rb_predmet.Checked == true)
            {
                EditPredmet();
            }
            if (rb_obor.Checked == true)
            {
                EditObor();
            }

            if (rb_katedra.Checked == true)
            {
                EditKatedra();
            }
        }

        private void EditGarant()
        {

        }
        private void EditPredmet()
        {

        }
        private void EditObor()
        {
            if (cb_obo.SelectedIndex != -1)
            {
                using (FormCUObor Obo = new FormCUObor())
                {
                    Obo.Text = "Upravit Katedru";
                    foreach (Obor o in obors)
                    {
                        if (o.ToString() == cb_obo.SelectedItem.ToString())
                        {
                            try
                            {
                                Obo.O = new Obor(o.Id_obor,
                                                 o.Zkr_obor,
                                                 o.Name_obor,
                                                 o.Rok_obor,
                                                 o.P_obor,
                                                 o.Pv_obor,
                                                 o.V_obor,
                                                 o.Vs_obor,
                                                 o.Praxe);
                            }
                            catch
                            {
                                Obo.Id = o.Id_obor.ToString();
                                Obo.Zkr = o.Zkr_obor;
                                Obo.Nazev = o.Name_obor;
                                Obo.Rok = o.Rok_obor;
                                Obo.P = o.P_obor;
                                Obo.Pv = o.Pv_obor;
                                Obo.V = o.V_obor;
                                Obo.Vs = o.Vs_obor;
                                Obo.Praxe = o.Praxe;
                            }
                        }
                    }
                    DataAccess a = new DataAccess();
                    DialogResult potvrzeni = Obo.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud x = new DataCrud();
                        try
                        {
                            x.UpdateObor(Obo.O);
                            obors = a.GetFullObor();
                            cb_obo.Text = Obo.O.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Úprava proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void EditKatedra()
        {
            if (cb_kat.SelectedIndex != -1)
            {
                using (FormCUKatedra Kat = new FormCUKatedra())
                {
                    Kat.Text = "Upravit Katedru";
                    foreach (Katedra o in katedras)
                    {
                        if (o.ToString() == cb_kat.SelectedItem.ToString())
                        {
                            Kat.Id = o.Id_k;
                            Kat.Zkr = o.Zkr_k;
                            Kat.Nazev = o.Naz_k;
                        }
                    }
                    DataAccess a = new DataAccess();
                    DialogResult potvrzeni = Kat.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud x = new DataCrud();
                        try
                        {
                            x.UpdateKatedra(Kat.K);
                            katedras = a.GetFullKatedra();
                            cb_kat.Text = Kat.K.ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Úprava proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Bt_smazat_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                DeleteGarant();
            }
            if (rb_predmet.Checked == true)
            {
                DeletePredmet();
            }
            if (rb_obor.Checked == true)
            {
                DeleteObor();
            }

            if (rb_katedra.Checked == true)
            {
                DeleteKatedra();
            }
        }
        public void DeleteGarant()
        {
           if (cb_garant.SelectedIndex != -1)
            {
                foreach (Garant o in garants)
                {

                    if (o.ToString() == cb_garant.SelectedItem.ToString())
                    {
                        try
                        {
                            DataCrud dc = new DataCrud();
                            dc.DeleteGarant(o.Id_v);
                            DataAccess da = new DataAccess();
                            garants = da.GetFullGarant();
                            cb_garant.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze smazat\n " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Smazání garanta proběhlo úspěšně", "Smazáno", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        public void DeletePredmet()
        {
            if (cb_pre.SelectedIndex != -1)
            {
                foreach (Predmet o in predmets)
                {

                    if (o.ToString() == cb_pre.SelectedItem.ToString())
                    {
                        try
                        {
                            DataCrud dc = new DataCrud();
                            dc.DeletePredmet(o.Id_predmet);
                            DataAccess da = new DataAccess();
                            predmets = da.GetFullPredmet();
                            cb_pre.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze smazat\n " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Smazání předmětu proběhlo úspěšně", "Smazáno", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        public void DeleteObor()
        {
            if (cb_obo.SelectedIndex != -1)
            {
                foreach (Obor o in obors)
            {

                    if (o.ToString() == cb_obo.SelectedItem.ToString())
                    {
                        try
                        {
                            DataCrud dc = new DataCrud();
                            dc.DeleteObor(o.Id_obor);
                            DataAccess da = new DataAccess();
                            obors = da.GetFullObor();
                            cb_obo.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze smazat\n " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Smazání oboru proběhlo úspěšně", "Smazáno", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        public void DeleteKatedra()
        {
            if (cb_kat.SelectedIndex != -1)
            {
                foreach (Katedra o in katedras)
                {

                    if (o.ToString() == cb_kat.SelectedItem.ToString())
                    {
                        try
                        {
                            DataCrud dc = new DataCrud();
                            dc.DeleteKatedra(o.Id_k);
                            DataAccess da = new DataAccess();
                            katedras = da.GetFullKatedra();
                            cb_kat.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nelze smazat\n " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Smazání katedry proběhlo úspěšně", "Smazáno", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
    }
}
