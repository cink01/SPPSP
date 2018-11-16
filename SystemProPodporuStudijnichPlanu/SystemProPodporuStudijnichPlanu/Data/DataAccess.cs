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
        public List<Predmet> GetPredmetFull(int idSemestr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SystemProPodporuStudijnichPlanu.Properties.Settings.SPTSPConnectionString")))
            {
                var vystup = connection.Query<Predmet>($"Select * from Predmet where SemestrPredmet='{ idSemestr }'").ToList();
                return vystup;
            }
        }
    }
}
