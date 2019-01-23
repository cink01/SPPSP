using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataCrud
    {
        public void InsertKat(string zkratka, string nazev)
        {
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess da = new DataAccess();
                da.CheckExistKatedra(nazev, out int exist);
                if (exist <= 0)
                {
                    SqlCommand kat = new SqlCommand("insert into [katedra]([zkr_k],[naz_k]) values(@zkr_k,@naz_k)", conn);
                    kat.Parameters.AddWithValue("@zkr_k", zkratka);
                    kat.Parameters.AddWithValue("@naz_k", nazev);
                    try
                    {
                        conn.Open();
                        kat.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
        }
        public void InsertObor(string zkr, string naz, string rok, int p, int pv, int v, int vs)
        {
            DataAccess da = new DataAccess();
            da.CheckExistObor(naz, out int exist);
            if (exist <= 0)
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
                {
                    SqlCommand obor = new SqlCommand("insert into obor(zkr_obor,name_obor,rok_obor,p_obor,pv_obor,v_obor,vs_obor) values(@zkr,@naz,@rok,@p,@pv,@v,@vs)", conn);
                    obor.Parameters.AddWithValue("@zkr", zkr);
                    obor.Parameters.AddWithValue("@naz", naz);
                    obor.Parameters.AddWithValue("@rok", rok);
                    obor.Parameters.AddWithValue("@p", p);
                    obor.Parameters.AddWithValue("@pv", pv);
                    obor.Parameters.AddWithValue("@v", v);
                    obor.Parameters.AddWithValue("@vs", vs);
                    try
                    {
                        conn.Open();
                        obor.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
        }
        public void InsertGarant(string jmeno_v, string email_v, string kat, string tel_v = "XXXX", string konz_v = "XXX")
        {
            DataAccess da = new DataAccess();
            da.CheckExistGarant(jmeno_v, out int exit);
            if (exit <= 0)
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
                {

                    //kontrola jestli neexistuje již existuje
                    SqlCommand garant = new SqlCommand("insert into garant(jmeno_v,email_v,tel_v,konz_v,id_k) values(@jmeno_v,@email_v,@tel_v,@konz_v,@id_k)", conn);
                    int katedra = da.GetKatedraId(kat);
                    garant.Parameters.AddWithValue("@jmeno_v", jmeno_v);
                    garant.Parameters.AddWithValue("@email_v", email_v);
                    garant.Parameters.AddWithValue("@tel_v", tel_v);
                    garant.Parameters.AddWithValue("@konz_v", konz_v);
                    garant.Parameters.AddWithValue("@id_k", katedra);
                    try
                    {
                        conn.Open();
                        garant.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
        }
        public void InsertPredmet(Predmet p)
        {
            DataAccess da = new DataAccess();
            da.CheckExistPredmet(p.Name_predmet,p.Id_obor, out int exist);
            if (exist <= 0)
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
                {
                    SqlCommand pred = new SqlCommand("insert into [predmet]([name_predmet],[zkr_predmet],[kredit_predmet],[id_obor],[id_v],[semestr_predmet],[id_orig],[povinnost],[prednaska],[cviceni],[kombi],[lab],[jazyk],[zakonceni])" +
                        "values(@name_predmet,@zkr_predmet,@kredit_predmet,@id_obor,@id_v,@semestr_predmet,@id_orig,@povinnost,@prednaska,@cviceni,@kombi,@lab,@jazyk,@zakonceni)", conn);
                    pred.Parameters.AddWithValue("@name_predmet", p.Name_predmet);
                    pred.Parameters.AddWithValue("@zkr_predmet", p.Zkr_predmet);
                    pred.Parameters.AddWithValue("@kredit_predmet", p.Kredit_predmet);
                    pred.Parameters.AddWithValue("@id_obor", p.Id_obor);
                    pred.Parameters.AddWithValue("@id_v", p.Id_v);
                    pred.Parameters.AddWithValue("@semestr_predmet", p.Semestr_predmet);
                    pred.Parameters.AddWithValue("@id_orig", p.Id_orig);
                    pred.Parameters.AddWithValue("@povinnost", p.Povinnost);
                    pred.Parameters.AddWithValue("@prednaska", p.Prednaska);
                    pred.Parameters.AddWithValue("@cviceni", p.Cviceni);
                    pred.Parameters.AddWithValue("@kombi", p.Kombi);
                    pred.Parameters.AddWithValue("@lab", p.Lab);
                    pred.Parameters.AddWithValue("@jazyk", p.Jazyk);
                    pred.Parameters.AddWithValue("@zakonceni", p.Zakonceni);
                    try
                    {
                        conn.Open();
                        pred.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
        }
        public void InsertPopis(string p, string text, string rok)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand pop = new SqlCommand("update [predmet] set [popis]=@popis where [id_predmet]=@id_predmet", conn);
                pop.Parameters.AddWithValue("@popis", text);
                pop.Parameters.AddWithValue("@id_predmet", da.GetPredmetId(p, rok));
                try//zkouska zapisu
                {
                    conn.Open();
                    pop.ExecuteNonQuery();
                }
                catch (Exception ex)//kdyz neprobehne tak se vypíše chyba
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        public void InsertZaznam(string nazev, string o)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("insert into zaznam(zkr_zaznam,id_obor) values(@zz,@id_o)", conn);
                zaz.Parameters.AddWithValue("@zz", nazev);
                zaz.Parameters.AddWithValue("@id_o", da.GetOborId(o));
                try
                {
                    conn.Open();
                    zaz.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        public void InsertPS(int semestr, string z)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("insert into plansemestr(zkr_zaznam,id_obor) values(@zz,@id_o)", conn);
                zaz.Parameters.AddWithValue("@zz", semestr);
                zaz.Parameters.AddWithValue("@id_o", da.GetZaznamId(z));
                try
                {
                    conn.Open();
                    zaz.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        public void InsertVyber(string predmet, int semestr, string rok, string zaz)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand vyb = new SqlCommand("insert into vyber(id_predmet,id_ps) values(@id_p,@id_ps)", conn);
                vyb.Parameters.AddWithValue("@id_p", da.GetPredmetId(predmet, rok));
                vyb.Parameters.AddWithValue("@id_ps", da.GetPSId(zaz, semestr));
                try
                {
                    conn.Open();
                    vyb.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
    }
}
