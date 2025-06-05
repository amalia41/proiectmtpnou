using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyMonitor 
{
    public static class DataManager
    {
        private static string filePath = "activitati.csv"; 


        public static void SalveazaActivitate(Activitate activitate)
        {
            
            string csvLine = $"{activitate.DataOra.ToString("yyyy-MM-dd HH:mm:ss")}," +
                             $"{activitate.TipActivitate}," +
                             $"{activitate.CantitateHranire}," +
                             $"{activitate.TipHrana}," +
                             $"{activitate.OraInceputSomn.ToString("yyyy-MM-dd HH:mm:ss")}," +
                             $"{activitate.OraSfarsitSomn.ToString("yyyy-MM-dd HH:mm:ss")}," +
                             $"{activitate.TipScutec}," +
                             $"{activitate.TipJoaca}," +
                             $"{activitate.DurataJoacaMinute}";

            try
            {
               
                if (!File.Exists(filePath))
                {
                    string header = "DataOra,TipActivitate,CantitateHranire,TipHrana,OraInceputSomn,OraSfarsitSomn,TipScutec,TipJoaca,DurataJoacaMinute";
                    File.WriteAllText(filePath, header + Environment.NewLine);
                }

                
                File.AppendAllText(filePath, csvLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
              
                System.Windows.Forms.MessageBox.Show($"Eroare la salvarea activității: {ex.Message}", "Eroare Salvare", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

       
        public static List<Activitate> CitesteActivitati()
        {
            List<Activitate> activitati = new List<Activitate>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 9) 
                    {
                        try
                        {
                            Activitate activitate = new Activitate
                            {
                                DataOra = DateTime.Parse(parts[0]),
                                TipActivitate = parts[1],
                                CantitateHranire = float.Parse(parts[2]),
                                TipHrana = parts[3],
                                OraInceputSomn = DateTime.Parse(parts[4]),
                                OraSfarsitSomn = DateTime.Parse(parts[5]),
                                TipScutec = parts[6],
                                TipJoaca = parts[7],
                                DurataJoacaMinute = int.Parse(parts[8])
                            };
                            activitati.Add(activitate);
                        }
                        catch (FormatException fx)
                        {
                           
                            Console.WriteLine($"Eroare de formatare la citirea liniei CSV: {lines[i]} - {fx.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Eroare la citirea liniei CSV: {lines[i]} - {ex.Message}");
                        }
                    }
                }
            }
            return activitati;
        }
        public static void RescrieActivitati(List<Activitate> activitati)
        {
            try
            {
                string header = "DataOra,TipActivitate,CantitateHranire,TipHrana,OraInceputSomn,OraSfarsitSomn,TipScutec,TipJoaca,DurataJoacaMinute";
   
                File.WriteAllText(filePath, header + Environment.NewLine);

                foreach (var activitate in activitati)
                {
                    string csvLine = $"{activitate.DataOra.ToString("yyyy-MM-dd HH:mm:ss")}," +
                                     $"{activitate.TipActivitate}," +
                                     $"{activitate.CantitateHranire}," +
                                     $"{activitate.TipHrana}," +
                                     $"{activitate.OraInceputSomn.ToString("yyyy-MM-dd HH:mm:ss")}," +
                                     $"{activitate.OraSfarsitSomn.ToString("yyyy-MM-dd HH:mm:ss")}," +
                                     $"{activitate.TipScutec}," +
                                     $"{activitate.TipJoaca}," +
                                     $"{activitate.DurataJoacaMinute}";
                    File.AppendAllText(filePath, csvLine + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Eroare la rescrierea fișierului de activități: {ex.Message}", "Eroare Salvare", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}