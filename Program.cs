using System;

namespace Aufgabe1._2
{
    class Program
    {
    
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
         static int gedicht = subjects.Length;
        static void Main(string[] args)
        {
            string[] vers = new string[gedicht];
            for (int i = 0; i < gedicht; i++)
            {
                GetVers();
                vers[i] = subjects + " " + verbs + " " + objects;
            }
            for (int j = 0; j < gedicht; j++)
            {
                 Console.WriteLine(vers[j]);
            }

         void GetVers() {
        
            Random rnd = new Random();
         int numbersubjects = rnd.Next(0, gedicht);
        int numberverbs = rnd.Next(0, gedicht);
        int numberobjects = rnd.Next(0, gedicht);
        
            while (subjects[numbersubjects] == "used")
            {
                numbersubjects = rnd.Next(0, gedicht);
            }
            while (verbs[numberverbs] == "used")
            {
                numberverbs = rnd.Next(0, gedicht);
            }
            while (objects[numberobjects] == "used")
            {
                numberobjects = rnd.Next(0, gedicht);
            }

          

            subjects[numbersubjects] = "used";
            verbs[numberverbs] = "used";
            objects[numberobjects] = "used";
    }
        }
   }   }
