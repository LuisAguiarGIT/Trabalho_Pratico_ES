using TrabalhoClinicaVeterinaria.Animal;

namespace TrabalhoClinicaVeterinaria.People
{
    public class Client : Person
    {
        public Pet Pet = null;
        public Client(string ClientName, int ClientContact, string ClientAddress, int Id)
        {
            Name = ClientName;
            Contact = ClientContact;
            Address = ClientAddress;
            ID = Id;
        } 
        public override string Name { get; set; }

        public override int Contact { get; set; }

        public override string Address { get; set; }

        public override int ID { get; set; }

    }
}
