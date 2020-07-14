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
            Name = "Human";
            Habitat = "Earth";
            Eats = "Anything";
        }
    }
}
