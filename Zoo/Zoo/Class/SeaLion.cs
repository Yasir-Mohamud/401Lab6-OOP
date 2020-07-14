using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// Concrete class.The SeaLion is the derived class and the LandAndSea is the parent class/
    /// </summary>
    public class SeaLion:LandAndSea
    {
        public SeaLion()
        {
            Name = "Sea Lion";
            Habitat = "Land or Sea";
            Eats = "Fish";
        }
    }
}
