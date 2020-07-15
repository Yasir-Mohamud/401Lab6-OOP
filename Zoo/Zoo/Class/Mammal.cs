using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. The Mammal is the derived class and the Animal is the parent class
    /// </summary>
    abstract public class Mammal:Animal
    {

        public string Tempreture { get; set; }

        public abstract string TypeOfEater();

        public sealed override string GivesBirth()
        {
            string message = $"{Name} gives birth and does not lay eggs because it is a mammal";
            Console.WriteLine(message);
            return message;
        }


    }
}
