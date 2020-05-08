using System.Collections.Generic;
namespace Herencia
{
    public class Driver : Person, ICalifications<Passenger>
    {
        private List<int> calificationsList = new List<int>();
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

        // El metodo hace que el Driver califque al Passenger.
        public void Califications(Passenger passenger, int score)
        {   
            
           
            if (0<=score && score<=5)
            {  
                int sumaDeCalificaciones = 0;
                passenger.AddItem(score);
                int cantidad = passenger.CalificationsList.Count;
                
                foreach (int i in passenger.CalificationsList)
                {
                    sumaDeCalificaciones += i;
                }
                passenger.Calification = (sumaDeCalificaciones / cantidad);
            }
            
        }
    }
}
