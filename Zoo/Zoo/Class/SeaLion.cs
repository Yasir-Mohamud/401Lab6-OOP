using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.The SeaLion is the derived class and the LandAndSea is the parent class/
    /// </summary>
    public class SeaLion:LandAndSea
    {
        public SeaLion()
        {
            Name = "Wally the sea lion";
            Habitat = "Land or Sea";
            Eats = "Fish";
        }

        public override string TypeOfEater()
        {
            string message = "I am a carnivore, I eat fish";
            Console.WriteLine(message);
            return message;
        }
    }
}
