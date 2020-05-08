using System.Collections.Generic;
namespace Herencia
{
    public class Driver : Person, ICalifications<Passenger>
    {
        private List<int> calificationsList = new List<int>{0};
        private int calification;
        private int passengersCount;
        public Driver(string name, string surname, int iD, string vehicle, string biography, int passengerCount):base(name,surname,iD)
        {
            this.Biography = biography;
            this.Vehicle = vehicle;
            this.CalificationsList = calificationsList;
            this.Calification = calification;
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

        public string Biography{get;set;}
        public string Vehicle{get;set;}
        public int Calification{get;set;}
        public List<int> CalificationsList{get;set;}
        public List<int> AddItem(int value)
        {
            calificationsList.Add(value);
            return calificationsList;
        }

        // el metodo califica al pasajero.
        public void Califications(Passenger passenger, int score)
        {   
            int sumaDeCalificaciones = 0;
            int cantidad = passenger.CalificationsList.Count;

            if (0<=score && score<=5)
            {  
                
                passenger.AddItem(score);
                
                foreach (int i in passenger.CalificationsList)
                {
                    sumaDeCalificaciones += i;
                }
            }
            passenger.Calification = (sumaDeCalificaciones / cantidad);
        }
    }
}