using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.
    /// Dolphin is the derived class and Sea is the parent class
    /// </summary>
    public class Dolphin:Sea
    {
        public Dolphin()
        {
            Name = "Skippy the Dolphin";
            Habitat = "Water";
        }


        /// <summary>
        /// Overrides the abbstract function TyprOfEater
        /// </summary>
        /// <returns>Name of and a message</returns>
        public override string TypeOfEater()
        {
            string message = $"{Name} am a carnivore, I eat fish";
            Console.WriteLine(message);
            return message;
        }

    }
}
