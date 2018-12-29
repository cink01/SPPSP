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
        public void InsertObor(string zkr,string naz, string rok,int p,int pv,int v,int vs)
        {
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                SqlCommand obor = new SqlCommand("insert into obor(zkr_obor,name_obor,rok_obor,p_obor,pv_obor,v_obor,vs_obor) values(@zkr,@naz,@rok,@p,@pv,@v,@vs)", conn);
                obor.Parameters.AddWithValue("@zkr", zkr);
                obor.Parameters.AddWithValue("@naz", naz);
                obor.Parameters.AddWithValue("@rok",rok);
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
         public void InsertVyuc(string jmeno_v, string email_v,string tel_v,string konz_v,string kat)
        {
        	DataAccess da = new DataAccess();
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                SqlCommand vyuc = new SqlCommand("insert into obor(jmeno_v,email_v,tel_v,konz_v,id_k) values(@jmeno_v,@email_v,@tel_v,@konz_v,@id_k)", conn);
                vyuc.Parameters.AddWithValue("@jmeno_v", jmeno_v);
                vyuc.Parameters.AddWithValue("@email_v", email_v);
                vyuc.Parameters.AddWithValue("@tel_v",tel_v);
                vyuc.Parameters.AddWithValue("@konz_v", konz_v);
                vyuc.Parameters.AddWithValue("@id_k", da.GetKatedraId(kat));
                try
                {
                    conn.Open();
                    vyuc.ExecuteNonQuery();
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
