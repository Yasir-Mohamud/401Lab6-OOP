using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. The Sea is the derived class and the Mammal is the parent class
    /// </summary>
    public abstract class Sea:Mammal
    {
        public Sea()
        {
            Tempreture = "cool";
        }
    }
}
