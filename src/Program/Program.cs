using System;
using System.Collections;
using Herencia;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {  
            
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

            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter($"Bienvenido {conductor1.Name}! El nuevo Conductor Pool de UCURide que llevará hasta {conductor1.PassengersCount} pasajeros Bio: {conductor1.Biography} ",@"images.jpg"));
            

        }
    }
}
