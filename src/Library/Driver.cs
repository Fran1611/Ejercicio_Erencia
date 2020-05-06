using System.Collections.Generic;
namespace Herencia
{
    public class Driver : Person, ICalifications<Passenger>
    {
        private string biography; 
        private string vehicle;

        private List<int> calificationsList = new List<int>();
        public Driver(string name, string surname, int iD, string vehicle, string biography):base(name,surname,iD)
        {
            this.Biography = biography;
            this.Vehicle = vehicle;
        }

        public string Biography{get;set;}
        public string Vehicle{get;set;}

        public int DriverTotalCalification{get;set;}
        public List<int> CalificationsList{get;set;}

        public List<int> AddItem(int value)
        {
            calificationsList.Add(value);
            return calificationsList;
        }

        // el metodo
        public void Califications(Passenger passenger, int score)
        {   
            int sumaDeCalificaciones = 0;
            int cantidad = calificationsList.Count;

            if (0<=score && score<=5)
            {  
                
                AddItem(score);
                
                foreach (int i in calificationsList)
                {
                    sumaDeCalificaciones += i;
                }
            }
            DriverTotalCalification = (sumaDeCalificaciones / cantidad);
        }
    }
}