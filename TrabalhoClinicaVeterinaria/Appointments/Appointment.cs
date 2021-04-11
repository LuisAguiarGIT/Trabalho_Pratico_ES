using TrabalhoClinicaVeterinaria.Animal;
using TrabalhoClinicaVeterinaria.People;
using TrabalhoClinicaVeterinaria.Clinic;

namespace TrabalhoClinicaVeterinaria.Appointments
{
    public class Appointment
    {
        public Appointment (Client AppointmentClient, Pet AppointmentPet, Employee AppointmentEmployee, Services AppointmentService)
        {
            Client = AppointmentClient;
            Pet = AppointmentPet;
            Employee = AppointmentEmployee;
            Service = AppointmentService;
        }

        public Client Client { get; set; }
        public Pet Pet { get; set; }
        public Employee Employee { get; set; }

        public Services Service { get; set; }

    }
}
