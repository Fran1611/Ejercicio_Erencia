using System.Collections.Generic;
namespace Herencia
{
    public class Passenger : Person, ICalifications<Driver>

    {   
        private List<int> calificationsList = new List<int>();
        public Passenger(string name, string surname, int iD): base(name,surname,iD)
        {
            
        }

        public int PassengerTotalCalification{get;set;}
        public List<int> CalificationsList{get;set;}

        public List<int> AddItem(int value)
        {
            calificationsList.Add(value);
            return calificationsList;
        }


        // el metodo recibe driver que califica al pasajero.
        public void Califications(Driver driver, int score)
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
            PassengerTotalCalification = (sumaDeCalificaciones / cantidad);
        }
    }
}