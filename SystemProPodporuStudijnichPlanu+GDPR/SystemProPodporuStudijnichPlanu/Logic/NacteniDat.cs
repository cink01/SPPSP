using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public class NacteniDat
    {
        public void Proved(string path)
        {
            StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
            DataCrud DC = new DataCrud();
            try
            {
                while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
                {
                    string line = reader.ReadLine();
                    string[] fulldata = line.Split(';');//rozlozeni prvku v line do prvku pole fulldata k jednoduššímu přístupu 
                    //vložení dat do insertu do databaze
                    //naplnění dat do kateder
                    DC.InsertKat(fulldata[13],//zkratka
                                 fulldata[12]);//nazev
                    //naplnění dat do oborů
                    DC.InsertObor(new Obor(fulldata[5],//zkratka
                                           fulldata[5],//nazev
                                           fulldata[5],//rok
                                           154, 20, 4, 2));//pocty kreditu defaultni hodnota
                    //naplnění dat do garantů
                    DC.InsertGarant(new Garant(fulldata[11],//jmeno
                                               fulldata[15],//email
                                               fulldata[12]));//katedra
                    //naplnění předmětů bez popisu
                    DC.InsertPredmetHromada(new Predmet(fulldata[1],//název
                                                        fulldata[2],//zkratka
                                                        fulldata[3],//kredit
                                                        fulldata[5],//obor
                                                        fulldata[11],//garant
                                                        fulldata[6],//semestr
                                                        fulldata[0],//orig
                                                        fulldata[10],//povinnost
                                                        fulldata[16],//prednaska
                                                        fulldata[17],//cviceni
                                                        fulldata[19],//kombi
                                                        fulldata[20],//lab
                                                        fulldata[22],//jazyk
                                                        fulldata[4]));//zakončení
                }
                MessageBox.Show(Properties.Resources.SuccNact_MESSAGE, 
                				Properties.Resources.Info_TITLE, 
                				MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show(Properties.Resources.ChybneNacteni_MESSAGE + ex, 
                				Properties.Resources.Chyba_TITLE, 
                				MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private const int PocetPrvku = 5;
        public void ProvedPopis(string path)
        {
            DataCrud DC = new DataCrud();
            //načtení celého textu do stringu
            List<string> fulldata = File.ReadAllText(path).Split('~').ToList();
            //procházení pole a zápis do db krok po každých šesti datech
            for (int i = 0; i < fulldata.Count(); i += PocetPrvku)
            {
                try
                {
                    //načtení dat vždy 1., 3. a 4. v pořadí od 0+(n*V) kde n začíná od 0 až do konce souboru
                    DC.InsertPopis(new Predmet(fulldata[i + 1],//nazev predmetu
                                               fulldata[i + 3],//text popisu
                                               fulldata[i + 4]));//rok oboru/označení
                    MessageBox.Show(Properties.Resources.SuccNact_MESSAGE, 
                                    Properties.Resources.Info_TITLE,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)//zachycení chyby
                {
                    MessageBox.Show("Načtení dat skončilo na indexu: " + i + "s chybou: " + ex, 
                                    Properties.Resources.Chyba_TITLE, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}