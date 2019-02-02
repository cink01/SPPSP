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
        public void InsertObor(Obor o)
        {
            DataAccess da = new DataAccess();
            da.CheckExistObor(o.Name_obor, out int exist);
            if (exist <= 0)
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
                {
                    SqlCommand obor = new SqlCommand("insert into obor(zkr_obor,name_obor,rok_obor,p_obor,pv_obor,v_obor,vs_obor,praxe) values(@zkr,@naz,@rok,@p,@pv,@v,@vs,@praxe)", conn);
                    obor.Parameters.AddWithValue("@zkr", o.Zkr_obor);
                    obor.Parameters.AddWithValue("@naz", o.Name_obor);
                    obor.Parameters.AddWithValue("@rok", o.Rok_obor);
                    obor.Parameters.AddWithValue("@p", o.P_obor);
                    obor.Parameters.AddWithValue("@pv", o.Pv_obor);
                    obor.Parameters.AddWithValue("@v", o.V_obor);
                    obor.Parameters.AddWithValue("@vs", o.Vs_obor);
                    obor.Parameters.AddWithValue("@praxe", o.Praxe);
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
        public void InsertGarant(Garant g)
        {
            DataAccess da = new DataAccess();
            da.CheckExistGarant(g.Jmeno_v, out int exit);
            if (exit <= 0)
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
                {
                    //kontrola jestli neexistuje již existuje
                    SqlCommand garant = new SqlCommand("insert into garant(jmeno_v,email_v,tel_v,konz_v,id_k) values(@jmeno_v,@email_v,@tel_v,@konz_v,@id_k)", conn);
                    garant.Parameters.AddWithValue("@jmeno_v", g.Jmeno_v);
                    garant.Parameters.AddWithValue("@email_v", g.Email_V);
                    garant.Parameters.AddWithValue("@tel_v", g.Tel_v);
                    garant.Parameters.AddWithValue("@konz_v", g.Konz_v);
                    garant.Parameters.AddWithValue("@id_k", g.Id_k);
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
            da.CheckExistPredmet(p.Name_predmet, p.Id_obor, out int exist);
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
        public void InsertPopis(Predmet p)
        {
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand pop = new SqlCommand("update [predmet] set [popis]=@popis where [id_predmet]=@id_predmet", conn);
                pop.Parameters.AddWithValue("@popis", p.Popis);
                pop.Parameters.AddWithValue("@id_predmet", p.Id_predmet);
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
        public void InsertZaznam(string nazev, string o, int PS)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("insert into zaznam(zkr_zaznam,id_obor,pocetSem) values(@zz,@id_o,@pocetSem)", conn);
                zaz.Parameters.AddWithValue("@zz", nazev);
                zaz.Parameters.AddWithValue("@id_o", da.GetOborId(o));
                zaz.Parameters.AddWithValue("@pocetSem", PS);
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
        public void DeleteZaznam(int id)
        {
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("DELETE FROM [zaznam] WHERE [id_zaznam]=@id_zaznam", conn);
                zaz.Parameters.AddWithValue("@id_zaznam", id);
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
        public void UpdateZaznam(int id_z, string nazev, int PS)
        {
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("UPDATE zaznam " +
                    "SET zkr_zaznam=@zz, pocetSem=@pocetSem " +
                    "WHERE id_zaznam=@id_zaznam", conn);
                zaz.Parameters.AddWithValue("@zz", nazev);
                zaz.Parameters.AddWithValue("@pocetSem", PS);
                zaz.Parameters.AddWithValue("@id_zaznam", id_z);
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
        public void InsertPS(string zaznam, int Semestr)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zaz = new SqlCommand("insert into plansemestr(sem_ps,id_zaznam) values(@sem_ps,@id_zaznam)", conn);
                zaz.Parameters.AddWithValue("@sem_ps", Semestr);
                zaz.Parameters.AddWithValue("@id_zaznam", da.GetZaznamId(zaznam));
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
        public void DeletePlanSemestr(int id_z, int Semestr)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand zazD = new SqlCommand("DELETE FROM [plansemestr] WHERE [id_ps]=@id_ps", conn);
                zazD.Parameters.AddWithValue("@id_ps", da.GetPSId(id_z, Semestr));
                try
                {
                    conn.Open();
                    zazD.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        public void InsertVyber(string predmet, int semestr, string rok, int zaz)
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
        public void InsertVyber( int ipredmet, int semestr, int zaz)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(DataAccess.ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand vyb = new SqlCommand("insert into vyber(id_predmet,id_ps) values(@id_p,@id_ps)", conn);
                vyb.Parameters.AddWithValue("@id_p", ipredmet);
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
