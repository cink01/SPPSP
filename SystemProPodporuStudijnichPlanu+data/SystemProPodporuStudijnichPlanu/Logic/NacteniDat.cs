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
                MessageBox.Show("Načtení dat do databáze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)//zachycení chyby
            {
                MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private const int PocetPrvku = 5;
        public void ProvedPopis(string path)
        {
            DataCrud DC = new DataCrud();
            List<string> fulldata = new List<string>();
            fulldata = File.ReadAllText(path).Split('~').ToList();//načtení celého textu do stringu
            for (int i = 0; i < fulldata.Count(); i += PocetPrvku)//procázení pole a zápis do db krok po každých šesti datech
            {
                try
                {
                    //načtení dat vždy 1., 3. a 4. v pořadí od 0+(n*V) kde n začíná od 0 až do konce souboru
                    DC.InsertPopis(new Predmet(fulldata[i + 1],//nazev predmetu
                                               fulldata[i + 3],//text popisu
                                               fulldata[i + 4]));//rok oboru/označení
                }
                catch (Exception ex)//zachycení chyby
                {
                    MessageBox.Show("Načtení dat skončilo s chybou: na indexu: " + i + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Načtení dat do databáze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
/*  public void ProvedPopis(string path)
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
              string temp = "";
              int x = fulldata.Length;
              if (x == PocetPrvku)
              {
                  temp = fulldata[3];
              }
              else
              {
                  for (int j = 3; j < (x - 2); j++)
                  {
                      temp += fulldata[j];
                  }
              }
              DC.InsertPopis(fulldata[1], temp, fulldata[x-1]);
          }
      }
      catch (Exception ex)
      {
          MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
  }

  public void ProvedPopis(string path)
  {
      DataCrud DC = new DataCrud();
      List<string> fulldata = new List<string>();
      fulldata = File.ReadAllText(path).Split(';').ToList<string>();//načtení celého textu do stringu
      for (int i = 0; i < fulldata.Count(); i = i + PocetPrvku)//procázení pole a zápis do db krok po každých šesti datech
      {
          try
          {
              //načtení dat vždy 1., 3. a 4. v pořadí od 0+(n*V) kde n začíná od 0
              DC.InsertPopis(fulldata[i + 1], fulldata[i + 3], fulldata[i + 4]);
          }
          catch (Exception ex)//zachycení chyby
          {
           //   MessageBox.Show("Načtení dat skončilo s chybou: na indexu: " + i + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
      MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
  }*/
/*  public void ProvedPopis(string path)
  {
      string line = "";
      StreamReader reader = new StreamReader(path);//vytvorení čtení řádku ze souboru
      DataCrud DC = new DataCrud();
      try
      {
          while (reader.Peek() >= 0)//testovavni zda je jeste dalsi radek
          {
              line = reader.ReadLine(); //precteni radku
              ArrayList a = new ArrayList();
              a.Add(line.Split(';'));
              DC.InsertPopis(a[1], a[3], a[4]);
          }
          MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)//zachycení chyby
      {
          MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
  }
   private const int PocetPrvku = 5;
   private const int MAX=10768;
   public void ProvedPopis(string path)
   {
       DataCrud DC = new DataCrud();
       string all = File.ReadAllText(path);//načtení celého textu do stringu
       var s = new string[MAX];
       string[] fulldata = all.Split(';');//rozdělení stringu pod středníku
       try
       {
           for (int i = 0; i <= fulldata.Length; i = i + PocetPrvku)//procázení pole a zápis do db krok po každých šesti datech
           {
               //načtení dat vždy 1., 3. a 4. v pořadí od 0+(n*V) kde n začíná od 0
               DC.InsertPopis(fulldata[i + 1], fulldata[i + 3], fulldata[i + 4]);
           }
           MessageBox.Show("Načtení dat do databéze proběhlo úspešně", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
       catch (Exception ex)//zachycení chyby
       {
           MessageBox.Show("Načtení dat skončilo s chybou: " + ex, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
   }*/