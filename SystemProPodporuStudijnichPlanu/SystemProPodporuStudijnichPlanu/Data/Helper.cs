using System.Configuration;

namespace SystemProPodporuStudijnichPlanu
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

//<add name="SPTSPdb" connectionString=".;Database=SPTSP;TrustedConnection=True;" providerName="System.Data.SqlClient" />