using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person agustin = new Passenger("Agustin","Gonzalez", 45645641);
            Person alejandro = new Passenger("Alejandro","Affo", 65545646);
            Person valentina = new Passenger("Vale","Alvarez", 45644541);

            List<Person> pasajeros = new List<Person>();
            pasajeros.Add(agustin);
            pasajeros.Add(alejandro);
            pasajeros.Add(valentina);

            Person conductor1 = new Single("Pedro","Martinez",4546546,"Audi", "Estudiante", agustin);
            Person conductor2 = new Pool("Ignacio","Suarez",4111111,"Bmw", "Chofer profesional",pasajeros);

            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            



            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
