using System;
using System.Collections.Generic;
namespace Herencia
{
    public class Pool : Driver
    {
        private List<Passenger> passengers;
        public Pool(string name, string surname, int iD, string vehicle, string biography, List<Passenger> passengers):base(name,surname,iD,vehicle,biography)
        {
        }
    }
} 