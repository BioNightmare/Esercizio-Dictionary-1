using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Esercizio_Dictionary_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<ANAGRAFEITALIANA, List<string>> customAnagrafe = new Dictionary<ANAGRAFEITALIANA, List<string>>();

            customAnagrafe.Add(ANAGRAFEITALIANA.ASL, new());
            customAnagrafe.Add(ANAGRAFEITALIANA.COMUNE, new());
            customAnagrafe.Add(ANAGRAFEITALIANA.POLIZIA, new());
            customAnagrafe.Add(ANAGRAFEITALIANA.INPS, new());
            customAnagrafe.Add(ANAGRAFEITALIANA.SCUOLA, new());

            customAnagrafe[ANAGRAFEITALIANA.ASL].Add("Mario ASL");
            customAnagrafe[ANAGRAFEITALIANA.ASL].Add("Caterina ASL");
            customAnagrafe[ANAGRAFEITALIANA.ASL].Add("Francesco ASL");

            customAnagrafe[ANAGRAFEITALIANA.COMUNE].Add("Mario Comune");
            customAnagrafe[ANAGRAFEITALIANA.COMUNE].Add("Caterina Comune");
            customAnagrafe[ANAGRAFEITALIANA.COMUNE].Add("Francesco Comune");

            customAnagrafe[ANAGRAFEITALIANA.POLIZIA].Add("Mario Polizia");
            customAnagrafe[ANAGRAFEITALIANA.POLIZIA].Add("Caterina Polizia");
            customAnagrafe[ANAGRAFEITALIANA.POLIZIA].Add("Francesco Polizia");

            customAnagrafe[ANAGRAFEITALIANA.INPS].Add("Mario INPS");
            customAnagrafe[ANAGRAFEITALIANA.INPS].Add("Caterina INPS");
            customAnagrafe[ANAGRAFEITALIANA.INPS].Add("Francesco INPS");

            customAnagrafe[ANAGRAFEITALIANA.SCUOLA].Add("Mario Scuola");
            customAnagrafe[ANAGRAFEITALIANA.SCUOLA].Add("Caterina Scuola");
            customAnagrafe[ANAGRAFEITALIANA.SCUOLA].Add("Francesco Scuola");

            Console.WriteLine("Inserisci il nome del cittadino che stai cercando");
            Console.WriteLine("Utenti disponibili: Mario, Caterina, Francesco\n");
            string userInput = Console.ReadLine();

            if (userInput == "Mario")
            {
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.ASL][0]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.COMUNE][0]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.POLIZIA][0]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.INPS][0]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.SCUOLA][0]);
            }
            else if(userInput == "Caterina")
            {
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.ASL][1]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.COMUNE][1]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.POLIZIA][1]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.INPS][1]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.SCUOLA][1]);
            }
            else if(userInput == "Francesco")
            {
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.ASL][2]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.COMUNE][2]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.POLIZIA][2]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.INPS][2]);
                Console.WriteLine(customAnagrafe[ANAGRAFEITALIANA.SCUOLA][2]);
            }
            else
            {
                Console.WriteLine("Input non valido o cittadino inesistente");
            }
        }
    }

    public enum ANAGRAFEITALIANA
    {
        ASL,
        COMUNE,
        POLIZIA,
        INPS,
        SCUOLA
    }
}
