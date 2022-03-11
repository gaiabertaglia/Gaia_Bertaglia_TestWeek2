using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    internal class TasksManagement
    {
        internal static Tasks InserisciTask()
        {
            Tasks task = new Tasks();

            bool success;
            bool successData;
            bool success1;

            Console.WriteLine("Inserisci una descrizione: ");
            task.Descrizione = Console.ReadLine();
            
            success = DateTime.TryParse(Console.ReadLine(), out DateTime dataScadenza);
            success1 = ControlloData(dataScadenza);
            while (!(success && success1))
            {
                Console.WriteLine("Inserisci data di scadenza (dd/mm/yyyy): ");
                success = DateTime.TryParse(Console.ReadLine(), out dataScadenza);
                success1 = ControlloData(dataScadenza);
            }              
            task.DataScadenza = dataScadenza;

            Console.WriteLine("Indica il livello di priorità (Alto/Medio/Basso): ");
            task.LivelloPriorita = Console.ReadLine();

            return task;
        }
        public static void StampaTask(Tasks task)
        {
            Console.WriteLine(task);
        }

        public static void StampaTasks(ArrayList listaTasks)
        {
            foreach (Tasks task in listaTasks)
            {
                StampaTask(task);
            }
        }

        public static bool ControlloData(DateTime dataScadenza)
        {
            bool successData;
            int controllo = DateTime.Compare(dataScadenza, DateTime.Now);
            if (controllo < 0)
                successData = false;
            else if (controllo == 0)
                successData = false;
            else
                successData = true;

            return successData; 
        }

        public static void EliminaTask(ArrayList listaTasks)
        {
            //Cerco il task da eliminare attraverso la descrizione
            Tasks taskDaCancellare = CercaTask(listaTasks);
            if (taskDaCancellare != null)
            {
                listaTasks.Remove(taskDaCancellare);
                Console.WriteLine("Cancellazione avvenuta con successo");
            }
            else
            {
                Console.WriteLine("Task non trovato");
            }
        }

        public static Tasks CercaTask(ArrayList listaTasks)
        {
            Console.Write("Inserisci la descrizione esatta dell'impegno che desideri cancellare: ");
            string descrizione = Console.ReadLine();

            foreach (Tasks task in listaTasks)
            {                
                if (task.Descrizione.Equals(descrizione))
                {
                    return task; //non appena verifico quel task con quella descrizione lo restituisco 
                }

            }
            return null;
        }           

        
        
    }
}
