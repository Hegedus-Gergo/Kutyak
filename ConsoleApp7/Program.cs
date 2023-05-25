using System;
using LINQ;
using System.Collection.Generic;

namespace Kutyák
{ 
    internal class Program
    { 
    static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Kutyanevek.csv");
            List<string> kutyanevek = sr.ToList();
            Console.WriteLine(kutyanevek.length);
            StreamReader sr2 = new StreamReader("Kutyafajtak.csv");
            List<string> kutyafajtak = sr2.Split(";").ToList();
            StreamReader sr3 = new StreamReader("Kutyak.csv");
            List<string> kutyak = sr3.Split(";").ToList();

            double atlageletkor = kutyak.Where(x=>x kutyak[3]).Average(2);
            int idoskutyanev = kutyak.Where(x => x kutyak[3].Max()).kutyak[2];
            int idoskutyafajta = kutyak.Where(x => x kutyak[3].Max()).kutyak[1];
            string kutyafajta = kutyak.Where(x => x kutyak[4] == "2018 január 10");
            string legterheltebbnap = kutyak.Where(x => x kutyak[4].Count.Max());

            StreamWriter sw = new StreamWriter("Névstatisztika.txt");
         }
    }
}