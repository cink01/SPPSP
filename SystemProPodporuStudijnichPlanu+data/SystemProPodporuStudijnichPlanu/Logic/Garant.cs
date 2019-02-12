using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProPodporuStudijnichPlanu
{
    public class Garant
    {
        public Garant(string jmeno_v, string email_V, string kat,string tel_v= "neuveden", string konz_v="neuvedeny")
        {
            DataAccess da = new DataAccess();
            Jmeno_v = jmeno_v;
            Email_V = email_V;
            Tel_v = tel_v;
            Konz_v = konz_v;
            Id_k = da.GetKatedraId(kat);
        }
        public Garant(int id_v,string jmeno_v, string email_V, string kat,string tel_v= "neuveden", string konz_v="neuvedeny")
        {
            DataAccess da = new DataAccess();
            Id_v=id_v;
            Jmeno_v = jmeno_v;
            Email_V = email_V;
            Tel_v = tel_v;
            Konz_v = konz_v;
            Id_k = da.GetKatedraId(kat);
        }

        public Garant(int id_v, string jmeno_v, string email_V, string tel_v, string konz_v, int id_k)
        {
            Id_v = id_v;
            Jmeno_v = jmeno_v;
            Email_V = email_V;
            Tel_v = tel_v;
            Konz_v = konz_v;
            Id_k = id_k;
        }

        public int Id_v{get;set;}
        public string Jmeno_v{ get; set; }
        public string Email_V { get; set; }
        public string Tel_v { get; set; }
        public string Konz_v { get; set; }
        public int Id_k { get; set; }
    }
}
