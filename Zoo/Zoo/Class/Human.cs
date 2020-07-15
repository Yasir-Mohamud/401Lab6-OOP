using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.The Human is the derived class and the Land is the parent class/
    /// </summary>
    public class Human : Land
    {
        public Human()
        {
            Name = "Yasir";
            Habitat = "Earth";
            Eats = "Anything";
        }

        public override string TypeOfEater()
        {
            string message = $"{Name} am a omnivore , I eat plants and meat";
            Console.WriteLine(message);
            return message;
        }
    }


   
}
