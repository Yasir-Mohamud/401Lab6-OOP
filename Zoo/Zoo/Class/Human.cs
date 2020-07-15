using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.
    /// Human is the derived class and Land is the parent class/
    /// </summary>
    public class Human : Land
    {
        public Human()
        {
            Name = "Yasir";
            Habitat = "Earth";
        }

        /// <summary>
        /// Overrides the abbstract function TyprOfEater
        /// </summary>
        /// <returns>Name of and a message</returns>
        public override string TypeOfEater()
        {
            string message = $"{Name} am a omnivore , I eat plants and meat";
            Console.WriteLine(message);
            return message;
        }
    }


   
}
