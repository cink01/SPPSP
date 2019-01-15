using System;
using System.IO;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class NacteniDat
    {
        public void Proved(string path)
        {
            string line = "";
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    line = reader.ReadLine(); //precteni radku
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                                                        //vložení dat do insertu do databaze
                    if (fulldata[6] == "")
                        fulldata[6] = "0";
                    if (fulldata[16] == "")
                        fulldata[16] = "0";
                    if (fulldata[17] == "")
                        fulldata[17] = "0";
                    if (fulldata[19] == "")
                        fulldata[19] = "0";
                    if (fulldata[20] == "")
                        fulldata[20] = "0";
                    DC.InsertKat(fulldata[13], fulldata[12]);//naplnění dat do kateder
                    DC.InsertObor(fulldata[5], fulldata[5], fulldata[5], 168, 12, 4, 2);//naplnění dat do oborů
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private const int PocetPrvku = 6;
        public void ProvedPopis(string path)
        {
            DataCrud DC = new DataCrud();
            string all = File.ReadAllText(path);//načtení celého textu do stringu
            string[] fulldata = all.Split(';');//rozdělení stringu pod středníku
            try
            {
                for (int i = 0; i <= fulldata.Length; i = i + PocetPrvku)//procázení pole a zápis do db krok po každých šesti datech
                {
                    DC.InsertPopis(fulldata[i + 1], fulldata[i + 3], fulldata[i + 4]);//načtení dat vždy 1., 3. a 4. v pořadí od 0+(n*V) kde n začíná od 0
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProvedUcitel(string path)
        {
            string line = "";
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    line = reader.ReadLine(); //precteni radku
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                                                        //vložení dat do insertu do databaze
                    DC.InsertVyuc(fulldata[11], fulldata[15], fulldata[12]);//naplnění garantů //ctu spatny data na email
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ProvedPredmety(string path)
        {
            string line = "";
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    line = reader.ReadLine(); //precteni radku
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                                                        //vložení dat do insertu do databaze
                    if (fulldata[6] == "")
                        fulldata[6] = "0";
                    if (fulldata[16] == "")
                        fulldata[16] = "0";
                    if (fulldata[17] == "")
                        fulldata[17] = "0";
                    if (fulldata[19] == "")
                        fulldata[19] = "0";
                    if (fulldata[20] == "")
                        fulldata[20] = "0";
                    DC.InsertPredmet(fulldata[2], fulldata[1], Convert.ToInt32(fulldata[3]), Convert.ToInt32(fulldata[6]), fulldata[5], Convert.ToInt32(fulldata[0]), fulldata[10], fulldata[22], fulldata[4], Convert.ToInt32(fulldata[16]), Convert.ToInt32(fulldata[17]), Convert.ToInt32(fulldata[19]), Convert.ToInt32(fulldata[20]));//naplnění předmětů
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ProvedUci(string path)
        {
            string line = "";
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    line = reader.ReadLine(); //precteni radku
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                                                        //vložení dat do insertu do databaze
                    DC.InsertUci(fulldata[1], fulldata[5], fulldata[12], fulldata[11]);//naplnění dat do tabulky vyučuje
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/*               string line = "";
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    line = reader.ReadLine(); //precteni radku
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                                                        //vložení dat do insertu do databaze
                    if (fulldata[6] == "")
                        fulldata[6] = "0";
                    if (fulldata[16] == "")
                        fulldata[16] = "0";
                    if (fulldata[17] == "")
                        fulldata[17] = "0";
                    if (fulldata[19] == "")
                        fulldata[19] = "0";
                    if (fulldata[20] == "")
                        fulldata[20] = "0";
                    DC.InsertKat(fulldata[13], fulldata[12]);//naplnění dat do kateder
                    DC.InsertObor(fulldata[5], fulldata[5], fulldata[5], 168, 12, 4, 2);//naplnění dat do oborů
                    DC.InsertVyuc(fulldata[11], fulldata[15], fulldata[12]);//naplnění garantů //ctu spatny data na email
                    DC.InsertPredmet(fulldata[2], fulldata[1], Convert.ToInt32(fulldata[3]), Convert.ToInt32(fulldata[6]), fulldata[5], Convert.ToInt32(fulldata[0]),fulldata[10], fulldata[22], fulldata[4], Convert.ToInt32(fulldata[16]), Convert.ToInt32(fulldata[17]), Convert.ToInt32(fulldata[19]),Convert.ToInt32(fulldata[20]));//naplnění předmětů
                    DC.InsertUci(fulldata[1], fulldata[5], fulldata[12],fulldata[11]);//naplnění dat do tabulky vyučuje
                }
                MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   */
