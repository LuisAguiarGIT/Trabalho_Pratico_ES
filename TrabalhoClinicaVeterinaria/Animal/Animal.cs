namespace TrabalhoClinicaVeterinaria.Animal
{
    public class Pet
    {
        public Pet(string AnimalName, int AnimalAge, string AnimalGender, string AnimalSpecies, int Id)
        {
            Name = AnimalName;
            Age = AnimalAge;
            Gender = AnimalGender;
            Species = AnimalSpecies;
            ID = Id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string Species { get; private set; }
        public int ID { get; private set; }

    }

}
