using System;
using System.Collections.Generic;
using System.Text;

namespace Bollette.Entities
{
    internal class Utente
    {
        // Campi

        private string _codice = "xxxxx";
        private string _nome = "xxxxx";
        private string _cognome = "xxxxx";
        private DateTime _dataNascita = new DateTime(2000, 1, 1);

        // Proprietà
        public string Codice
        {
            get { return _codice; } 
            set { _codice = value; }    
        } 

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }    
            set { _cognome = value; }
        }

        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Cognome: {Cognome} - Data di nascita {DataNascita.ToShortDateString()} - Codice: {Codice}";
        }

    }
}
