using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    /// <summary>
    /// This is a Abstract class. 
    /// LandAndSea is the derived class and Mammal is the parent class
    /// </summary>
    /// 
    public abstract class LandAndSea:Mammal
    {
        public override string Tempreture { get ; set ; }


        public LandAndSea()
        {
            Tempreture = "Cool and Hot";
           
        }
    }
}
