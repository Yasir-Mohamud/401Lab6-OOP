using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public class Ape:Land
    {
        /// <summary>
        /// Concrete class.The Ape is the derived class and the Land is the parent class
        /// </summary>
        public Ape()
        {
            Name = "King Kong";
            Habitat = "Earth";
            Eats = "Banana";
        }

        public override string TypeOfEater()
        {
            string message = $"{Name} am a herbavore , i eat plants and fruits";
            Console.WriteLine(message);
            return message;
        }

    }
}
