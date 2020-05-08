using System.Collections.Generic;
using System;
namespace Herencia
{
    public class Passenger : Person, ICalifications<Driver>

    {   
        private List<int> calificationsList = new List<int>();
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

        // El metodo hace que el Passenger califique al Driver.
        public void Califications(Driver driver, int score)
        {   
            
           
            if (0<=score && score<=5)
            {  
                int sumaDeCalificaciones = 0;
                driver.AddItem(score);
                int cantidad = (driver.CalificationsList.Count);
                
                foreach (int i in driver.CalificationsList)
                {
                    sumaDeCalificaciones += i;
                }
            
                driver.Calification = (sumaDeCalificaciones / cantidad);
            }
            
        }
    }
}
