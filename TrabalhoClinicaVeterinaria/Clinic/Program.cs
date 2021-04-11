using TrabalhoClinicaVeterinaria.Clinic;

namespace TrabalhoClinicaVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ClinicSim myClinic = new("Milos");

            myClinic.GenerateClinicWorkforce();
            myClinic.RunClinicSim();
            
        }
    }
}
