using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. 
    /// Mammal is the derived class and Animal is the parent class
    /// </summary>
    abstract public class Mammal:Animal
    {
       // Abstract property
        public abstract string Tempreture { get; set; }

        // Virtual property
        public virtual string Hair { get; set; }

        public override string BloodTempreture { get; set; } = "Warm blooded";

        public Mammal()
        {
            Hair = "I have little hair";
        }


        // Abstract method
        public abstract string TypeOfEater();

        /// <summary>
        /// A sealed overriden method
        /// </summary>
        /// <returns> message</returns>
        public sealed override string GivesBirth()
        {
            string message = $"{Name} gives birth and does not lay eggs because it is a mammal";
            Console.WriteLine(message);
            return message;
        }

        // Abstract Method
        public virtual string Breathe()
        {
            string message = $"{Name} breathes using lungs";
            Console.WriteLine(message);
            return message;
        }
        
    }
}
