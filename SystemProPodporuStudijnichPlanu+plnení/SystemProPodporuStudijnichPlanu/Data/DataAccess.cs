using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace SystemProPodporuStudijnichPlanu
{
    public class DataAccess
    {
        public List<Predmet> GetPredmetFull(int semestr_predmet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                var vystup = connection.Query<Predmet>($"Select * from predmet where semestr_predmet='{ semestr_predmet }'").ToList();
                return vystup;
            }
        }

        public int GetOborId(string obor)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.Query($"Select id_obor from obor where rok_obor='{ obor }'"));
            }
        }
        public int GetKatedraId(string katedra)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.Query($"Select id_k from katedra where naz_k='{ katedra }'")); ;
            }
        }
        public int GetPredmetId(string p,string rok)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess da = new DataAccess();
                return Convert.ToInt32(connection.Query($"Select id_predmet from predmet where name_predmet='{ p }'AND id_obor='{da.GetOborId(rok)}'"));
            }
        }
        public int GetVyucujiciId(string v)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.Query($"Select id_v from obor where jmeno_v='{ v }'"));
            }
        }
        public int GetZaznamId(string z)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                return Convert.ToInt32(connection.Query($"Select id_zaznam from zaznam where zkr_zaznam='{ z }'"));
            }
        }
        public int GetPSId(string z, int s)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.DatabaseAppConnectionString")))
            {
                DataAccess a = new DataAccess();
                return Convert.ToInt32(connection.Query($"Select id_ps from plansemestr where id_zaznam='{ a.GetZaznamId(z) }'& sem_ps='{s}'"));
            }
        }
    }
}