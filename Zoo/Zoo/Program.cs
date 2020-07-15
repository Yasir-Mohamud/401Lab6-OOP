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

           
            human.Sound(human.Name);
            dolphin.Sound(dolphin.Name);
            whale.TypeOfEater();
            ape.TypeOfEater();
            seaLion.GivesBirth();
            Console.WriteLine(seaLion.BloodTempreture);

        }

    }
}
