using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.
    /// Ape is the derived class and Land is the parent class
    /// </summary>
    public class Ape:Land
    {
        
        public Ape()
        {
            Name = "King Kong";
            Habitat = "Earth";
        }


        /// <summary>
        /// Overrides the abbstract function TyprOfEater
        /// </summary>
        /// <returns>Name of and a message</returns>
        public override string TypeOfEater()
        {
            string message = $"{Name} am a herbavore , i eat plants and fruits";
            Console.WriteLine(message);
            return message;
        }

    }
}
