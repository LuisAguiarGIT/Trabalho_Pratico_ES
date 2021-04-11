using System;
using System.Collections.Generic;
using TrabalhoClinicaVeterinaria.Appointments;
using TrabalhoClinicaVeterinaria.People;
using TrabalhoClinicaVeterinaria.Animal;
using TrabalhoClinicaVeterinaria.Clinic;

namespace TrabalhoClinicaVeterinaria.Utility
{
    class PrinterUtility
    {
        public static void GenerateReport(List<Appointment> AppointmentList)
        {
            foreach (Appointment AppointmentEntry in AppointmentList)
            {
                Console.WriteLine("############################");
                Console.WriteLine("Client name: {0}\nClient pet name: {1}\n", AppointmentEntry.Client.Name, AppointmentEntry.Client.Pet.Name);
                Console.WriteLine("Health professional: {0}\n", AppointmentEntry.Employee.Name);
                Console.WriteLine("Service: {0}", AppointmentEntry.Service.Name);
                Console.WriteLine("############################");
            }
        }

        public static void PrintRegisteredClients(List<Client> RegisteredClients)
        {
            foreach (Client client in RegisteredClients)
            {
                Console.WriteLine("##################################");
                Console.WriteLine("ID: {0} \nClient name: {1} \nClient contact: {2} \nClient address: {3} ", client.ID, client.Name, client.Contact, client.Address);
                if (client.Pet != null)
                {
                    Console.WriteLine("Pet: {0}", client.Pet.Name);
                }
                Console.WriteLine("##################################");
            }
        }

        public static void PrintRegisteredAnimals(List<Pet> RegisteredAnimals)
        {
            foreach (Pet pet in RegisteredAnimals)
            {
                Console.WriteLine("##################################");
                Console.WriteLine("ID: {0} Animal name: {1} Age: {2} Gender: {3} Species: {4}", pet.ID, pet.Name, pet.Age, pet.Gender, pet.Species);
                Console.WriteLine("##################################");
            }

        }

        public static void PrintServices(List<Services> ServiceList)
        {
            Console.Clear();
            foreach (Services service in ServiceList)
            {
                Console.WriteLine("####################################");
                Console.WriteLine("Service: {0} \nPrice: {1} \nDuration: {2} H", service.Name, service.Price, service.Duration);
                if (service.Medicine != "None")
                {
                    Console.WriteLine("Medicine: {0}", service.Medicine);
                }
                foreach (Employee ServiceEmployee in service.ServiceEmployees)
                {
                    Console.WriteLine(ServiceEmployee.ID + " - " + ServiceEmployee.Name + " - " + "Shift: " + ServiceEmployee.Shift);
                }
            }
        }
    }

}
