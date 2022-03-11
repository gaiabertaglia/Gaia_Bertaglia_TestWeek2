using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    internal class Tasks
    {
        private string _descrizione = "xxxxx"; 
        private DateTime _dataScadenza = new DateTime(2000, 1, 1);
        private string _livelloPriorita = "xxxxx";        

        public string Descrizione
        {
            get { return _descrizione; }    
            set { _descrizione = value; }
        }

        public DateTime DataScadenza
        {
            get { return _dataScadenza; }   
            set { _dataScadenza = value; }  
        }

        public string LivelloPriorita
        {
            get { return _livelloPriorita; }
            set { _livelloPriorita = value; }
        }

        public override string ToString()
        {
            // return $"Descrizione {Descrizione} - DataDiScadenza {DataScadenza.ToShortDateString()} - Livello di priorità {LivelloPriorita}";
            return $" {Descrizione} -  {DataScadenza.ToShortDateString()} -  {LivelloPriorita}";
        }
    }
}
