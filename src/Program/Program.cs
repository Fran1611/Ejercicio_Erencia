﻿using System;
using System.Collections;
using Herencia;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
           /*string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "eAut3eKlWwBB0o1BfTRLaRBfOgXF6WriMKwpkevgf7C2t";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";*/

            // token nuevos
            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("Probando ",@"img.jpg"));
            
             Passenger valentina = new Passenger("Valentina","Alvarez",52315904);
            Passenger agustin = new Passenger("Agustin","Gonzalez",7894561);
            Passenger francisco = new Passenger("Francisco","Ibañez",45678904);
            Passenger alejandro = new Passenger("Alejandro","Affonso",12478954);

            Driver conductor1 = new Pool("Juan","Perez",45789047, "Audi", "Hola! Soy estudiante en la UCU",4);

            
            
            valentina.Califications(conductor1, 5);
            agustin.Califications(conductor1, 4);
            francisco.Califications(conductor1, 4);
            alejandro.Califications(conductor1,5);

            conductor1.Califications(valentina,5);
            conductor1.Califications(agustin,4);
            conductor1.Califications(francisco,4);
            conductor1.Califications(alejandro,5);

            //var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            //Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "380889967"));

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
