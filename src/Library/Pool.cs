using System;
using System.Collections.Generic;
namespace Herencia
{
    public class Pool : Driver
    {
        private int passengersCount;
        public Pool(string name, string surname, int iD, string vehicle, string biography, int passengersCount):base(name,surname,iD,vehicle,biography)
        {
            this.PassengersCount = passengersCount;
        }

        public int PassengersCount 
        {
            get{return passengersCount;}
            
            set
            {
                if (0<= value && value<=4)
                {
                    passengersCount = value;
                }
            }
            
        }
    }
} 