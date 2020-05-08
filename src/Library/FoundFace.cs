using System.Collections.Generic;
using System;
using Herencia;

namespace Herencia
{
    public class FoundFace
    {
        public static void DriverFace(CognitiveFace cog, string Name, int PassengersCount, string Biography)
        {
            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);

            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                    Console.WriteLine(twitter.PublishToTwitter($"Bienvenido {Name}! El nuevo Conductor Pool de UCURide que llevará hasta {PassengersCount} pasajeros Bio: {Biography} ",@"sonrisa.jpg"));
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }

        public static void PassengerFace(CognitiveFace cog, string Name, string LastName, int Id)
        {
            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);

            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                Console.WriteLine(twitter.PublishToTwitter($"Bienvenido {Name} {LastName}! Nuevo usuario de la app con ci numero {Id}",@"images.jpg"));
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                    
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
    }
}