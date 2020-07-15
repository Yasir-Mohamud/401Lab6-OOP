using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. 
    /// Sea is the derived class and Mammal is the parent class
    /// </summary>
    public abstract class Sea:Mammal
    {
        public override string Tempreture { get; set; }
        public override string Breathe()
        {
            string message = $"{Name} breathes using gills";
            Console.WriteLine(message);
            return message;
        }
        public Sea()
        {
            Tempreture = "cool";
        }
    }
}
