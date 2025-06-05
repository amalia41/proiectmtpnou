using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyMonitor 
{
    public class Activitate
    {
        public DateTime DataOra { get; set; }
        public string TipActivitate { get; set; }
        public float CantitateHranire { get; set; } 
        public string TipHrana { get; set; }
        public DateTime OraInceputSomn { get; set; }
        public DateTime OraSfarsitSomn { get; set; }
        public string TipScutec { get; set; } 
        public string TipJoaca { get; set; }
        public int DurataJoacaMinute { get; set; } 

      
        public Activitate()
        {
            
            DataOra = DateTime.Now; 
            TipActivitate = "";
            CantitateHranire = 0;
            TipHrana = "";
            OraInceputSomn = DateTime.MinValue; 
            OraSfarsitSomn = DateTime.MinValue; 
            TipScutec = "";
            TipJoaca = "";
            DurataJoacaMinute = 0;
        }
    }
}