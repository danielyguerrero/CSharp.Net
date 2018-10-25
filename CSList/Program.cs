using System;

using System.Collections.Generic;

namespace CSList
{
    class Program
    {
        static void Main(string[] args)
        {
        


        //===================    LIST    =========================

        List<string>shows = new List<string>();

        shows.Add("Futurama");
        shows.Add("American Dad");
        shows.Add("Simpsons");
        shows.Add("How I Met Your Mother");

        Console.WriteLine(shows[0]);

        Console.WriteLine("There are currently {0} shows in this list.", shows.Count);



        }
    }
}
