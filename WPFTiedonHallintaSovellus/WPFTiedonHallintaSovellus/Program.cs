﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTiedonHallintaSovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //Kysytään käyttäjältä uutta lämpötilaa ja tallentaan se tiedostoon
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //Tiedostoon tallentaminen
            string tiedosto = @"C:\Temp\Lämpötila.txt"; //miukumerkki tarkoittaa että kenomerkki ei olekaan ESC -merkki!!!

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila " + lämpötila.ToString() + " on tallennettu");

            Console.ReadLine();


        }
    }
}
