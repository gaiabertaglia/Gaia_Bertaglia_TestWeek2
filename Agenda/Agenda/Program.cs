using System;
using System.Collections;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            ArrayList listaTasks = new ArrayList();
            ArrayList listaLivello = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = PrintMenu();

                switch (scelta)
                {
                    case 1:
                        // Visualizza i tasks in agenda
                        TasksManagement.StampaTasks(listaTasks);
                        break;
                    case 2:
                        // Aggiungi un nuovo task in agenda                        
                        listaTasks.Add(TasksManagement.InserisciTask());
                        break;
                    case 3:
                        // Eliminare un task esistente
                        TasksManagement.EliminaTask(listaTasks);
                        break;
                    case 4:
                        // Filtra i task per importanza 
                        
                        break;
                    case 5:
                        // Salva su file .txt
                        AgendaIO.StampaTasksSuFile(listaTasks);
                        break;
                    case 6:
                        // Carica task da file di testo
                        listaTasks = AgendaIO.CaricaTasksDaFile();
                        break;                    
                    default: //un numero diverso da 0
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }
        }

        public static int PrintMenu()
        {
            Console.WriteLine("*** Agenda Personale ***");
            Console.WriteLine("Cosa desideri fare? ");
            Console.WriteLine("1. Visualizza tasks");
            Console.WriteLine("2. Aggiungi un nuovo task");
            Console.WriteLine("3. Elimina un task esistente");
            Console.WriteLine("4. Filtra tasks per importanza (per livello di priorità)");
            Console.WriteLine("5. Salva su file.txt");
            Console.WriteLine("6. Leggi task da file");
            Console.WriteLine("Qualsiasi altro valore per uscire");
            Console.Write("Scelta: > ");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;
        }
    }
}
