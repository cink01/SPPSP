using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataCrud
    {
        public void InsertPredmet(string a, string b, string c, string d)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                // connection.ExecuteScalar($"insert into Predmet(ZkratkaPredmet,NazevPredmet,KreditPredmet,SemestrPredmet) values('{a}{b}{c}{d}')");
                SqlCommand cmd = new SqlCommand("insert into Predmet(ZkratkaPredmet,NazevPredmet,KreditPredmet,SemestrPredmet) values(@a,@b,@c,@d)",conn);
                cmd.Parameters.AddWithValue("@a", a);
                cmd.Parameters.AddWithValue("@b", b);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@d", d);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
     /*   public void InsertVyuc(string a, string b, string c, string d)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                // connection.ExecuteScalar($"insert into Predmet(ZkratkaPredmet,NazevPredmet,KreditPredmet,SemestrPredmet) values('{a}{b}{c}{d}')");
                SqlCommand cmd = new SqlCommand("insert into Predmet(ZkratkaPredmet,NazevPredmet,KreditPredmet,SemestrPredmet) values(@a,@b,@c,@d)", conn);
                cmd.Parameters.AddWithValue("@a", a);
                cmd.Parameters.AddWithValue("@b", b);
                cmd.Parameters.AddWithValue("@c", Convert.ToInt32( c));
                cmd.Parameters.AddWithValue("@d", Convert.ToInt32(d));
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }*/
    }
}
