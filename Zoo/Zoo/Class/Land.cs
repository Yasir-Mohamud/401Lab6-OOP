using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. The Land is the derived class and the Mammal is the parent class
    /// </summary>
    public abstract class Land:Mammal
    {
        public override string Tempreture { get; set; }

   
        public Land()
        {
            Tempreture = "cool and hot";
        }
    }
}
