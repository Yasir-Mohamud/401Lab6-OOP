using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{/// <summary>
/// Abstract class
/// </summary>
    public abstract class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Eats { get; set; }

        public Animal Animals(string type)
        {
            Animal animal = null;
            if (type == "Human")
            {
                animal = new Human();
            }
            else if (type == "Ape")
            {
                animal = new Ape();
            }
            else if (type == "Sea Lion")
            {
                animal = new SeaLion();
            }
            else if (type == "Whale")
            {
                animal = new Whale();
            }
            else if (type == "Dolphin")
            {
                animal = new Dolphin();
            }
            else
            {
                animal = null;
            }
            return animal;
        }

        /// <summary>
        /// Return a string that animal can make a sound
        /// </summary>
        /// <param name="name"> any name of an animal </param>
        /// <returns> message </returns>
        public string Sound(string name)
        {
            string message = $"{name} can make sounds";
            Console.WriteLine(message);
            return message;
        }
    }
}
