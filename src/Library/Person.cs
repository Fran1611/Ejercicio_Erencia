namespace Herencia

{
    public class Person
    {
        private string name;
        private string surname;
        private int iD;
        private string vehicle;
        public Person(string name, string surname, int iD, string vehicle)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = iD;
            this.Vehicle = vehicle;
        }
        
        public string Name {get;set;}
        public string Surname {get;set; }
        public int Id {get;set;}
        public string Vehicle {get;set;}

    }     
}