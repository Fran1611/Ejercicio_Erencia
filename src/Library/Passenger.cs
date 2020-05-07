using System.Collections.Generic;
using System;
namespace Herencia
{
    public class Passenger : Person, ICalifications<Driver>

    {   
        private List<int> calificationsList = new List<int>{0};
        private int calification;
        public Passenger(string name, string surname, int iD): base(name,surname,iD)
        {
            this.CalificationsList = calificationsList;
            this.Calification = calification;
        }

        public int Calification{get;set;}
        public List<int> CalificationsList{get;set;}
        public List<int> AddItem(int value)
        {
            calificationsList.Add(value);
            return calificationsList;
        }

        // el metodo recibe driver que califica al conductor.
        public void Califications(Driver driver, int score)
        {   
            int sumaDeCalificaciones = 0;
            int cantidad = (driver.CalificationsList.Count);

            if (0<=score && score<=5)
            {  
                
                driver.AddItem(score);
                
                foreach (int i in driver.CalificationsList)
                {
                    sumaDeCalificaciones += i;
                }
            }
            driver.Calification = (sumaDeCalificaciones / cantidad);
        }
    }
}