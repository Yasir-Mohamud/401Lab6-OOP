using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.The Whale is the derived class and the Sea is the parent class/
    /// </summary>
    public class Whale:Sea
    {

        public Whale()
        {
            Name = "Whale";
            Habitat = "Water";
            Eats = "Fish";
        }
    }
}
