using System;
using Zoo.Class;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            DisplayNames();
        }
        static void DisplayNames ()
        {
            Human human = new Human();
            Whale whale = new Whale();
            Dolphin dolphin = new Dolphin();
            SeaLion seaLion = new SeaLion();
            Ape ape = new Ape();


            human.GivesBirth();
            dolphin.Sound(dolphin.Name);
            ape.PlaysGames();
            whale.TypeOfEater();
            seaLion.Breathe();

        }

    }
}
