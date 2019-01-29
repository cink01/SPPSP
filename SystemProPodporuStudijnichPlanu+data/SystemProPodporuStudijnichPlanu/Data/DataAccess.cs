using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataAccess
    {
        private static SqlConnection conn = null;
        private readonly string ConnectionString = ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString");
        public static string ConnValue(string nazev)
        {
            return ConfigurationManager.ConnectionStrings[nazev].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
            }
            return conn;
        }
        public List<Predmet> GetPredmetFull(int semestr_predmet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where semestr_predmet='{ semestr_predmet }'").ToList();
                return vystup;
            }
        }
        public void CheckExistObor(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkObor = new SqlCommand("SELECT COUNT(*) FROM [obor] WHERE ([name_obor] = @name_obor)", GetConnection());
                checkObor.Parameters.AddWithValue("@name_obor", x);
                //zaznamenani jestli probehl select
                Exist = (int)checkObor.ExecuteScalar();
            }
        }
        public void CheckExistPredmet(string name_predmet, int id_obor, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkPredmet = new SqlCommand("SELECT COUNT(*) FROM [predmet] WHERE ([name_predmet] = @name_predmet)AND([id_obor]=@id_obor)", GetConnection());
                checkPredmet.Parameters.AddWithValue("@name_predmet", name_predmet);
                checkPredmet.Parameters.AddWithValue("@id_obor", id_obor);
                //zaznamenani jestli probehl select
                Exist = (int)checkPredmet.ExecuteScalar();
            }
        }
        public void CheckExistKatedra(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkKat = new SqlCommand("SELECT COUNT(*) FROM [katedra] WHERE ([naz_k] = @naz_k)", GetConnection());
                checkKat.Parameters.AddWithValue("@naz_k", x);
                //zaznamenani jestli probehl select
                Exist = (int)checkKat.ExecuteScalar();
            }
        }
        public void CheckExistGarant(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkGarant = new SqlCommand("SELECT COUNT(*) FROM [garant] WHERE ([jmeno_v] = @x)", GetConnection());
                checkGarant.Parameters.AddWithValue("@x", x);
                //zaznamenani jestli probehl select
                Exist = (int)checkGarant.ExecuteScalar();
            }
        }
        public int GetOborId(string o)
        {
            SqlCommand get_ID_obor = new SqlCommand("SELECT id_obor FROM [obor] WHERE ([rok_obor] = @obor)", GetConnection());
            get_ID_obor.Parameters.AddWithValue("@obor", o);
            return Convert.ToInt32(get_ID_obor.ExecuteScalar());
        }
        public int GetKatedraId(string katedra)
        {
            SqlCommand get_ID_Katedra = new SqlCommand("SELECT id_k FROM [katedra] WHERE ([naz_k] = @naz_k)", GetConnection());
            get_ID_Katedra.Parameters.AddWithValue("@naz_k", katedra);
            return Convert.ToInt32(get_ID_Katedra.ExecuteScalar());
        }
        public int GetPredmetId(string p, string rok)
        {
            SqlCommand get_ID_Predmet = new SqlCommand("SELECT id_predmet FROM [predmet] WHERE ([name_predmet] = @name_predmet)AND([id_obor] = @id_obor)", GetConnection());
            get_ID_Predmet.Parameters.AddWithValue("@name_predmet", p);
            get_ID_Predmet.Parameters.AddWithValue("@id_obor", GetOborId(rok));
            return Convert.ToInt32(get_ID_Predmet.ExecuteScalar());
        }
        public int GetGarantId(string v)
        {
            SqlCommand get_ID_Garant = new SqlCommand("SELECT id_v FROM [garant] WHERE ([jmeno_v] = @jmeno_v)", GetConnection());
            get_ID_Garant.Parameters.AddWithValue("@jmeno_v", v);
            return Convert.ToInt32(get_ID_Garant.ExecuteScalar());
        }



        public int GetZaznamId(string z)
        {
            SqlCommand get_ID_Zaznam = new SqlCommand("SELECT id_zaznam FROM [zaznam] WHERE ([zkr_zaznam] = @zkr_zaznam)", GetConnection());
            get_ID_Zaznam.Parameters.AddWithValue("@zkr_zaznam", z);
            return Convert.ToInt32(get_ID_Zaznam.ExecuteScalar());
        }
        public int GetPSId(string z, int s)
        {
            SqlCommand get_ID_Zaznam = new SqlCommand("SELECT id_ps FROM [plansemestr] WHERE ([id_zaznam] = @id_zaznam)AND([sem_ps]=@sem_ps)", GetConnection());
            get_ID_Zaznam.Parameters.AddWithValue("@id_zaznam", z);
            get_ID_Zaznam.Parameters.AddWithValue("@sem_ps", s);
            return Convert.ToInt32(get_ID_Zaznam.ExecuteScalar());
        }

        public void FillOborCB(ComboBox x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT rok_obor,id_obor FROM obor";
                    SqlDataAdapter da = new SqlDataAdapter(query,GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Obor");
                    x.DisplayMember = "rok_obor";
                    x.ValueMember = "id_obor";
                    x.DataSource = ds.Tables["Obor"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex);
                }
            }
        }
        public void FillGarantCB(ComboBox x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT jmeno_v,id_v FROM garant";
                    SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Garant");
                    x.DisplayMember = "jmeno_v";
                    x.ValueMember = "id_v";
                    x.DataSource = ds.Tables["Garant"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex);
                }
            }
        }
        public void FillKatedraCB(ComboBox x)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT id_k,naz_k FROM katedra";
                    SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Katedra");
                    x.DisplayMember = "naz_k";
                    x.ValueMember = "id_k";
                    x.DataSource = ds.Tables["Katedra"];
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