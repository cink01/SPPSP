using System;
using System.IO;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class NacteniDat
    {
        public void Proved(string path)
        {
            var line = "";
            var reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    //precteni radku
                    line = reader.ReadLine();
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                    //vložení dat do insertu do databaze

                    DC.InsertPredmet(fulldata[2], fulldata[1], fulldata[3], fulldata[6]);

                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProvedPopis(string path)
        {
            var line = "";
            var reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    //precteni radku
                    line = reader.ReadLine();
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                    //vložení dat do insertu do databaze

                    DC.InsertPredmet(fulldata[2], fulldata[1], fulldata[3], fulldata[6]);

                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
