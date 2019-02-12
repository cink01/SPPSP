﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProPodporuStudijnichPlanu
{
    public class Obor
    {
        public Obor(string zkr_obor, string name_obor, string rok_obor, int p_obor, int pv_obor, int v_obor, int vs_obor,string praxe="")
        {
            Zkr_obor = zkr_obor;
            Name_obor = name_obor;
            Rok_obor = rok_obor;
            P_obor = p_obor;
            Pv_obor = pv_obor;
            V_obor = v_obor;
            Vs_obor = vs_obor;
            Praxe = praxe;
        }
        public Obor(int id_obor, string zkr_obor, string name_obor, string rok_obor, int p_obor, int pv_obor, int v_obor, int vs_obor,string praxe="")
        {
            Id_obor = id_obor;
            Zkr_obor = zkr_obor;
            Name_obor = name_obor;
            Rok_obor = rok_obor;
            P_obor = p_obor;
            Pv_obor = pv_obor;
            V_obor = v_obor;
            Vs_obor = vs_obor;
            Praxe = praxe;
        }
        
        public int Id_obor{get;set;}
        public string Zkr_obor { get; set; }
        public string Name_obor { get; set; }
        public string Rok_obor { get; set; }
        public int P_obor { get; set; }
        public int Pv_obor { get; set; }
        public int V_obor { get; set; }
        public int Vs_obor { get; set; }
        public string Praxe { get; set; }
    }
}
