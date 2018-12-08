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

        // Console.WriteLine(shows[0]);

        // Console.WriteLine("There are currently {0} shows in this list.", shows.Count);


        //===================    Iterating through the list    =========================


        Console.WriteLine("The T.V Shows I have watched are: ");
        for(var i = 0; i < shows.Count; i++){
            Console.WriteLine("=> "+ shows[i]);
        }

        //===================    Inserting to a list   =========================

        shows.Insert(2,"Rick and Morty");

        Console.WriteLine("The T.V Shows I have watched are: ");
        for(var i = 0; i < shows.Count; i++){
            Console.WriteLine("* "+ shows[i]);
        }

        //===================    Removing from a list   =========================

        shows.Remove("How I Met Your Mother");


        for(var i = 0; i < shows.Count; i++){
            Console.WriteLine("--> "+ shows[i]);
        }

        //===================    Removing from a list   =========================

        Console.WriteLine("List of family-rated shows:");

        foreach(string show in shows){
            Console.WriteLine("# "+ show);
        }



        }
    }
}
