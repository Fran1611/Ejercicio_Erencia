namespace Herencia
{
    public class Single : Driver
    {
        private Passenger passenger;
        public Single(string name, string surname, int iD, string vehicle, string biography, Passenger passenger):base(name,surname,iD,vehicle,biography)
        {
        }
    }
}