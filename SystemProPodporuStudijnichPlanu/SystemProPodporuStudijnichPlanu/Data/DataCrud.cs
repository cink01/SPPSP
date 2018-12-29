using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataCrud
    {
        public void InsertPredmet(string a, string b, string c, string d,string ob)
        {
            DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                int obor = da.GetOborId(ob);
                SqlCommand pred = new SqlCommand("insert into predmet(zkr_predmet,name_predmet,kredit_predmet,semestr_predmet,id_obor) values(@a,@b,@c,@d,@obor)", conn);
                pred.Parameters.AddWithValue("@a", a);
                pred.Parameters.AddWithValue("@b", b);
                pred.Parameters.AddWithValue("@c", c);
                pred.Parameters.AddWithValue("@d", d);
                pred.Parameters.AddWithValue("@obor", obor);
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
        public void InsertKat(string a, string b)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                SqlCommand kat = new SqlCommand("insert into katedra(zkr_k,naz_k) values(@a,@b)", conn);
                kat.Parameters.AddWithValue("@a", a);
                kat.Parameters.AddWithValue("@b", b);
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
        public void InsertObor(string a, string b)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                SqlCommand kat = new SqlCommand("insert into katedra(zkr_k,naz_k) values(@a,@b)", conn);
                kat.Parameters.AddWithValue("@a", a);
                kat.Parameters.AddWithValue("@b", b);
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
}
