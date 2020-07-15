using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.
    /// SeaLion is the derived class and LandAndSea is the parent class
    /// </summary>
    public class SeaLion:LandAndSea
    {

        public SeaLion()
        {
            Name = "Wally the Sea Lion";
            Habitat = "Land or Sea";
            
        }

       





        /// <summary>
        /// Overrides the abbstract function TyprOfEater
        /// </summary>
        /// <returns>Name of and a message</returns>
        public override string TypeOfEater()
        {
            string message = "I am a carnivore, I eat fish";
            Console.WriteLine(message);
            return message;
        }
    }
}
