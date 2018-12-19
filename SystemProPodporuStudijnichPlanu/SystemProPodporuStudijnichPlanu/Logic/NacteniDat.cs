using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Logic
{
    class NacteniDat
    {
        private ArrayList shromazdeni { get; set; }
        NacteniDat(){
            shromazdeni = new ArrayList();
        }
        void Proved(string path)
        {
            shromazdeni.Clear();
            //var File;
            try
            {
                while (true)
                {

                }
                MessageBox.Show("Informace", "Načtení dat do databéze proběhlo úspešně", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba", "Načtení dat skončilo s chybou: "+ex, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }
    }
}
