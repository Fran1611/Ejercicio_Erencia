using System;
using System.Collections.Generic;
namespace Herencia
{
    public class Pool : Driver
    {
        
        public Pool(string name, string surname, int iD, string vehicle, string biography, int passengersCount):base(name,surname,iD,vehicle,biography,passengersCount)
        {
            this.PassengersCount = passengersCount;
        }
    }
} 