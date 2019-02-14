using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

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
        public List<Katedra> GetFullKatedra()
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return connection.Query<Katedra>($"Select * from [katedra]").ToList();
            }
        }
        public List<Obor> GetFullObor()
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return connection.Query<Obor>($"Select * from [obor]").ToList();
            }
        }
        public List<Garant> GetFullGarant()
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return connection.Query<Garant>($"Select * from [garant]").ToList();
            }
        }
        public List<Predmet> GetFullPredmet()
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return connection.Query<Predmet>($"Select * from [predmet]").ToList();
            }
        }
        public List<Predmet> GetPredmetFullByObor(int obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where id_obor='{obor}' AND (semestr_predmet=1 OR semestr_predmet=3 OR semestr_predmet=5 )").ToList();
                return vystup;

            }
        }
        public List<Garant> GetGarantByKatedra(int ikatedra)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return connection.Query<Garant>($"SELECT * FROM [garant] WHERE id_k='{ikatedra}'").ToList();
            }
        }
        
        public List<Predmet> GetPredmetFullSudy(string obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where id_obor='{GetOborId(obor)}' AND (semestr_predmet=1 OR semestr_predmet=3 OR semestr_predmet=5 )").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetFullLichy(string obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * " +
                    $"from predmet " +
                    $"where id_obor='{GetOborId(obor)}' AND(semestr_predmet=2 OR semestr_predmet=4 OR semestr_predmet=6)" +
                    $"ORDER BY semestr_predmet,povinnost").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetFullLichy(int id_obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where id_obor='{id_obor}' AND (semestr_predmet=1 OR semestr_predmet=3 OR semestr_predmet=5)" +
                    $"ORDER BY semestr_predmet,povinnost").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetFullSudy(int id_obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where id_obor='{id_obor}' AND(semestr_predmet=2 OR semestr_predmet=4 OR semestr_predmet=6)" +
                    $"ORDER BY semestr_predmet,povinnost").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetBySemestr(int semestr_predmet, int id_obor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select * from predmet where id_obor='{id_obor}' AND semestr_predmet='{ semestr_predmet }'").ToList();
                return vystup;
            }
        }

        public List<Predmet> GetPredmetZVyberu(int semestr, string zaznam, string rok)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>(
                    $"SELECT [predmet].* " +
                    $"FROM [predmet] NATURAL JOIN [vyber] NATURAL JOIN [plansemestr] NATURAL JOIN [zaznam] NATURAL JOIN [obor]" +
                    $" WHERE [obor].rok_obor='{ rok }'AND [zaznam].zkr_zaznam='{zaznam}'AND [plansemestr].sem_ps='{semestr}'").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetZVyberu(int seme, string zazn, int iobor)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>(
                    $"SELECT [predmet].* " +
                    $"FROM [predmet] NATURAL JOIN [vyber] NATURAL JOIN [plansemestr] NATURAL JOIN [zaznam] WHERE [predmet].id_obor='{ iobor }'AND [zaznam].zkr_zaznam='{zazn}'AND [plansemestr].sem_ps='{seme}'" +
                    $"ORDER BY [predmet].semestr_predmet").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetZVyberu(int seme, int izaz)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>(
                    $"SELECT [predmet].* " +
                    $"FROM ([predmet] JOIN [vyber] ON [predmet].id_predmet= [vyber].id_predmet) JOIN [plansemestr] ON [plansemestr].id_ps = [vyber].id_ps  WHERE [plansemestr].id_zaznam='{izaz}'AND [plansemestr].sem_ps='{seme}'" +
                    $"ORDER BY [predmet].semestr_predmet").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetyVyberFull(int izaz)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>(
                    $"SELECT [predmet].* FROM ([predmet] JOIN [vyber] ON [predmet].id_predmet= [vyber].id_predmet) JOIN [plansemestr] ON [plansemestr].id_ps = [vyber].id_ps  " +
                    $"WHERE [plansemestr].id_zaznam='{izaz}'").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetFullLichyVyber(int id_obor, int izaz)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select [predmet].* from predmet where id_obor='{id_obor}' AND (semestr_predmet=1 OR semestr_predmet=3 OR semestr_predmet=5) " +
                    $"AND [predmet].id_predmet NOT IN(" +
                    $"SELECT [predmet].id_predmet " +
                    $"FROM ([predmet] JOIN [vyber] ON [predmet].id_predmet= [vyber].id_predmet) JOIN [plansemestr] ON [plansemestr].id_ps = [vyber].id_ps  " +
                    $"WHERE [plansemestr].id_zaznam='{izaz}')" +
                    $"ORDER BY semestr_predmet,povinnost").ToList();
                return vystup;
            }
        }
        public List<Predmet> GetPredmetFullSudyVyber(int id_obor, int izaz)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                List<Predmet> vystup = connection.Query<Predmet>($"Select [predmet].* from predmet where id_obor='{id_obor}' AND(semestr_predmet=2 OR semestr_predmet=4 OR semestr_predmet=6)" +
                    $"AND [predmet].id_predmet NOT IN(" +
                    $"SELECT [predmet].id_predmet " +
                    $"FROM ([predmet] JOIN [vyber] ON [predmet].id_predmet= [vyber].id_predmet) JOIN [plansemestr] ON [plansemestr].id_ps = [vyber].id_ps  " +
                    $"WHERE [plansemestr].id_zaznam='{izaz}')" +
                    $"ORDER BY semestr_predmet,povinnost").ToList();
                return vystup;
            }
        }
        public void CheckExistObor(string x, out int Exist)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkObor = new SqlCommand("" +
                    "SELECT COUNT(*) " +
                    "FROM [obor] " +
                    "WHERE ([name_obor] = @name_obor)", GetConnection());
                checkObor.Parameters.AddWithValue("@name_obor", x);
                //zaznamenani jestli probehl select
                Exist = (int)checkObor.ExecuteScalar();
            }
        }
        public void CheckExistVyber(int seme, int izaz, out int Exist)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    //chyba kolem where
                    SqlCommand checkVyber = new SqlCommand("SELECT COUNT(id_vyber) FROM [vyber] JOIN [plansemestr] ON [vyber].id_ps =[plansemestr].id_ps WHERE (id_zaznam=@izaz) AND (sem_ps=@seme)", GetConnection());
                    checkVyber.Parameters.AddWithValue("@izaz", izaz);
                    checkVyber.Parameters.AddWithValue("@seme", seme);
                    //zaznamenani jestli probehl select
                    Exist = (int)checkVyber.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba" + ex);
                    Exist = -1;
                }
            }
        }
        public void CheckExistPredmet(string name_predmet, int id_obor, out int Exist)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
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
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                SqlCommand checkKat = new SqlCommand("SELECT COUNT(*) FROM [katedra] WHERE ([naz_k] = @naz_k)", GetConnection());
                checkKat.Parameters.AddWithValue("@naz_k", x);
                //zaznamenani jestli probehl select
                Exist = (int)checkKat.ExecuteScalar();
            }
        }
        public void CheckExistGarant(string x, out int Exist)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
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
        public int GetVyberId(int izaz, int ipred, int sem)
        {
            SqlCommand get_ID_vyber = new SqlCommand("SELECT id_vyber FROM [vyber] JOIN [plansemestr] ON ([vyber].id_ps=[plansemestr].id_ps) WHERE ([plansemestr].id_zaznam = @id_zaznam) AND [vyber].id_predmet = @id_predmet AND [plansemestr].sem_ps=@sem_ps", GetConnection());
            get_ID_vyber.Parameters.AddWithValue("@id_zaznam", izaz);
            get_ID_vyber.Parameters.AddWithValue("@id_predmet", ipred);
            get_ID_vyber.Parameters.AddWithValue("@sem_ps", sem);
            return Convert.ToInt32(get_ID_vyber.ExecuteScalar());
        }
        public string GetOborRok(int o)
        {
            SqlCommand get_ID_obor = new SqlCommand("SELECT rok_obor FROM [obor] WHERE ([id_obor] = @obor)", GetConnection());
            get_ID_obor.Parameters.AddWithValue("@obor", o);
            return get_ID_obor.ExecuteScalar().ToString();
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
        public int GetZaznamSemestr(int z)
        {
            SqlCommand get_ID_Zaznam = new SqlCommand("SELECT pocetSem FROM [zaznam] WHERE ([id_zaznam] = @id_zaznam)", GetConnection());
            get_ID_Zaznam.Parameters.AddWithValue("@id_zaznam", z);
            return Convert.ToInt32(get_ID_Zaznam.ExecuteScalar());
        }
        public int GetPSId(int z, int s)
        {
            SqlCommand getIdPS = new SqlCommand("SELECT [id_ps] FROM [plansemestr] WHERE ([id_zaznam] = @id_zaznam)AND([sem_ps]=@sem_ps)", GetConnection());
            getIdPS.Parameters.AddWithValue("@id_zaznam", z);
            getIdPS.Parameters.AddWithValue("@sem_ps", s);
            return Convert.ToInt32(getIdPS.ExecuteScalar());
        }
        //nahradit/prepsat Funkce kolem tvorby zaznamu a nebo tyto 2 nechat jak jsou
        public void FillOborCB(ComboBox x)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT rok_obor,id_obor FROM obor";
                    SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Obor");
                    x.DisplayMember = "rok_obor";
                    x.ValueMember = "id_obor";
                    x.DataSource = ds.Tables["Obor"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!" + ex);
                }
            }
        }
        public void FillZaznamCB(ComboBox x)
        {
            using (IDbConnection connection = new SqlConnection(ConnValue("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                try
                {
                    string query = "SELECT id_zaznam,zkr_zaznam FROM zaznam";
                    SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Zaznam");
                    x.DisplayMember = "zkr_zaznam";
                    x.ValueMember = "id_zaznam";
                    x.DataSource = ds.Tables["Zaznam"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!" + ex);
                }
            }
        }
        public void GetZaznamFull(int id, out int obor, out int PocetSem)
        {
            SqlCommand SelectZaz = new SqlCommand("SELECT [zaznam].[id_obor], [zaznam].[pocetSem] FROM [zaznam] WHERE [zaznam].[id_zaznam] =@id_zaznam", GetConnection());
            SelectZaz.Parameters.AddWithValue("@id_zaznam", id);
            using (var reader = SelectZaz.ExecuteReader())
            {
                if (reader.Read()) // Don't assume we have any rows.
                {
                    obor = reader.GetInt32(reader.GetOrdinal("id_obor"));
                    PocetSem = reader.GetInt32(reader.GetOrdinal("pocetSem"));
                }
                else
                {
                    obor = -1;
                    PocetSem = -1;
                }
            }
        }
    }
}