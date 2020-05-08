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

           

            //Se debe pasar por parametro la API Key y el color del recuadro a dibujar 
            //en caso de encontrar una cara en la foto
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", true);
            cog.Recognize(@"sonrisa.jpg");
            Herencia.FoundFace.DriverFace(cog,conductor1.Name,conductor1.PassengersCount,conductor1.Biography);
            cog.Recognize(@"images.jpg");
            Herencia.FoundFace.PassengerFace(cog,valentina.Name,valentina.Surname,valentina.Id);
            
        }
    
    
    }
}
