namespace TrabalhoClinicaVeterinaria.People
{
    public abstract class Person 
    {
        public abstract string Name { get; set; }
        public abstract int Contact { get; set;  }

        public abstract string Address { get; set; }
        
        public abstract int ID { get; set; }
    }
}
