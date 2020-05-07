using System.Collections.Generic;
namespace Herencia
{
    public class Driver : Person, ICalifications<Passenger>
    {
        private string biography; 
        private string vehicle;
        private List<int> calificationsList;
        private int calification;
        public Driver(string name, string surname, int iD, string vehicle, string biography):base(name,surname,iD)
        {
            this.Biography = biography;
            this.Vehicle = vehicle;
            this.CalificationsList = calificationsList;
            this.Calification = calification;
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