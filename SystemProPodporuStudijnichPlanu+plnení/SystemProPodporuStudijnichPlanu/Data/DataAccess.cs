using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataAccess
    {
        private static SqlConnection conn = null;

        private string ConnectionString = Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString");//ConfigurationManager.ConnectionStrings["ConnectionString_seznam_volnych_clanku"].ConnectionString;
        public SqlConnection getConnection()
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                var vystup = connection.Query<Predmet>($"Select * from predmet where semestr_predmet='{ semestr_predmet }'").ToList();
                return vystup;
            }
        }
        public void checkExistObor(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkObor = new SqlCommand("SELECT COUNT(*) FROM [obor] WHERE ([name_obor] = @name_obor)",getConnection());
                checkObor.Parameters.AddWithValue("@name_obor", x);
                //zaznamenani jestli probehl select
                try
                {
                    Exist = (int)checkObor.ExecuteScalar();
                }
                catch
                {

                    Exist = -1;
                }

            }
        }
        public void checkExistKatedra(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkKat = new SqlCommand("SELECT COUNT(*) FROM [katedra] WHERE ([naz_k] = @naz_k)", getConnection());
                checkKat.Parameters.AddWithValue("@naz_k", x);
                //zaznamenani jestli probehl select
                try
                {
                    Exist = (int)checkKat.ExecuteScalar();
                }
                catch
                {
                    Exist = 0;
                }

            }
        }
        public void checkExistGarant(string x, out int Exist)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkGarant = new SqlCommand("SELECT COUNT(*) FROM [garant] WHERE ([jmeno_v] = @x)", getConnection());
                checkGarant.Parameters.AddWithValue("@x", x);
                //zaznamenani jestli probehl select
                try
                {
                    Exist = (int)checkGarant.ExecuteScalar();
                }
                catch
                {
                    Exist = 0;
                }
            }
        }
        public int GetOborId(string oborr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.ExecuteScalar($"Select id_obor from obor where rok_obor='{ oborr }'"));
            }
        }
        public int GetKatedraId(string katedra)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.ExecuteScalar($"Select id_k from katedra where naz_k='{ katedra }'"));
            }
        }
        public int GetPredmetId(string p, string rok)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess da = new DataAccess();
                return Convert.ToInt32(connection.ExecuteScalar($"Select id_predmet from predmet where name_predmet='{ p }'AND id_obor='{da.GetOborId(rok)}'"));
            }
        }
        public int GetGarantId(string v)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess da = new DataAccess();
                int x;
                try
                {
                    var a = connection.ExecuteScalar($"Select id_v from garant where jmeno_v='{ v }'");
                    x = (int)a;
                    return x;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
        }
        public int GetZaznamId(string z)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.ExecuteScalar($"Select id_zaznam from zaznam where zkr_zaznam='{ z }'"));
            }
        }
        public int GetPSId(string z, int s)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess a = new DataAccess();
                return Convert.ToInt32(connection.ExecuteScalar($"Select id_ps from plansemestr where id_zaznam='{ a.GetZaznamId(z) }'& sem_ps='{s}'"));
            }
        }
    }
}