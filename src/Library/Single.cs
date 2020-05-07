namespace Herencia
{
    public class Single : Driver
    {
        private int passengerCount;
        public Single(string name, string surname, int iD, string vehicle, string biography, int passengersCount = 1):base(name,surname,iD,vehicle,biography)
        {
            this.PassengersCount = passengersCount;
        }

        public int PassengersCount {get;}
    }
}