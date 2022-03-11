using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Agenda
{
    internal class AgendaIO
    {
        public static void StampaTasksSuFile(ArrayList listaTasks)
        {
            //Mi faccio restituire il percorso su desktop con il file tasks.txt
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tasks.txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Tasks tasksDaStampareSuFile in listaTasks)
                {
                    //sw.WriteLine($"Nome: {personaDaStampareSuFile.Nome} - ");
                    sw.WriteLine(tasksDaStampareSuFile);
                }
            }
        }

        public static ArrayList CaricaTasksDaFile()
        {
            ArrayList tasksCaricatiDaFile = new ArrayList();
            //carichiamo i valori a partire dal file
            //specifico il path del file da cui leggere
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tasks.txt");
            string line; //stringa che conterrà la linea che leggo da file
            //apro il flusso di lettura
            
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while (line != null) //finchè c'è qualcosa da leggere nel file vado avanti
                {
                    string[] valoriTask = line.Split('-');
                    string descrizione = valoriTask[0];
                    DateTime.TryParse(valoriTask[1], out DateTime dataScadenza);
                    string livelloPriorita = valoriTask[2];                   
                                        
                    Tasks t = new Tasks()
                    {
                        Descrizione = descrizione,                        
                        DataScadenza = dataScadenza,
                        LivelloPriorita = livelloPriorita,

                    };
                    tasksCaricatiDaFile.Add(t);
                    line = sr.ReadLine();
                }
            }

            return tasksCaricatiDaFile;
        }
    }
}
