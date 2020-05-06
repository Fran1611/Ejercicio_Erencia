namespace Herencia

{
    public class Person
    {
        private string name;
        private string surname;
        private int iD;
        
        public Person(string name, string surname, int iD)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = iD;
        }
        
        public string Name {get;set;}
        public string Surname {get;set; }
        public int Id {get;set;}
    }     
}