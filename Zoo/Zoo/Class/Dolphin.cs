using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.The Dolphin is the derived class and the Sea is the parent class/
    /// </summary>
    public class Dolphin:Sea
    {
        public Dolphin()
        {
            Name = "Dolphin";
            Habitat = "Water";
            Eats = "Fish";
        }
    }
}
