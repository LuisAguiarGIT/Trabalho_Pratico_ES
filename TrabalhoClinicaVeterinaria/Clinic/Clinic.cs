using System;
using System.Collections.Generic;
using TrabalhoClinicaVeterinaria.People;
using TrabalhoClinicaVeterinaria.Animal;
using TrabalhoClinicaVeterinaria.Helpers;
using TrabalhoClinicaVeterinaria.Generators;
using TrabalhoClinicaVeterinaria.Appointments;
using TrabalhoClinicaVeterinaria.Utility;

namespace TrabalhoClinicaVeterinaria.Clinic
{
    public class ClinicSim
    {
        List<Client> RegisteredClients = new();
        List<Pet> RegisteredAnimals = new();
        List<Employee> EmployeeList = new();
        List<Services> ServiceList = new();
        List<Appointment> AppointmentHistory = new();

        public ClinicSim(string Name)
        {
            ClinicName = Name;
        }

        public string ClinicName { get; private set; }

        public void RegisterAnimal()
        {
            Console.Clear();
            Console.WriteLine("Please write the animals name: ");
            string AnimalName = Console.ReadLine();
            Console.WriteLine("Please write the animals age: ");
            int AnimalAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write the animals gender: ");
            string AnimalGender = Console.ReadLine();
            Console.WriteLine("Please write the animals species: ");
            string AnimalSpecies = Console.ReadLine();
            int ID = IDHelper.GenerateID();

            RegisteredAnimals.Add(new Pet(AnimalName, AnimalAge, AnimalGender, AnimalSpecies, ID));
            GoBackToMenu();

        }

        public void RegisterClient()
        {
            Console.Clear();
            Console.WriteLine("Please write the clients name: ");
            string ClientName = Console.ReadLine();
            Console.WriteLine("Please write the clients mobile phone number: ");
            int ClientContact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write the clients address: ");
            string ClientAddress = Console.ReadLine();
            int ID = IDHelper.GenerateID();


            RegisteredClients.Add(new Client(ClientName, ClientContact, ClientAddress, ID));
            GoBackToMenu();
        }

        public void PrintUserInterface()
        {
            Console.Clear();
            Console.WriteLine("##################################");
            Console.WriteLine("Welcome to our veterinary clinic {0}!", ClinicName);
            Console.WriteLine("##################################");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Register a client");
            Console.WriteLine("2 - Register an animal");
            Console.WriteLine("3 - List of registered clients");
            Console.WriteLine("4 - List of registered animals");
            Console.WriteLine("5 - List of services & corresponding health professional");
            Console.WriteLine("6 - Associate an animal to a client");
            Console.WriteLine("7 - Make an appointment");
            Console.WriteLine("8 - Generate report");

        }

        public void GenerateClinicWorkforce()
        {
            ClinicGenerator.GenerateServices(ServiceList);
            ClinicGenerator.GenerateEmployees(EmployeeList);
            AssociateEmployeeToService(EmployeeList, ServiceList);
        }

        public void RunClinicSim()
        {

            PrintUserInterface();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    RegisterClient();
                    break;
                case "2":
                    RegisterAnimal();
                    break;
                case "3":
                    PrinterUtility.PrintRegisteredClients(RegisteredClients);
                    GoBackToMenu();
                    break;
                case "4":
                    PrinterUtility.PrintRegisteredAnimals(RegisteredAnimals);
                    GoBackToMenu();
                    break;
                case "5":
                    PrinterUtility.PrintServices(ServiceList);
                    GoBackToMenu();
                    break;
                case "6":
                    AssociatePetToClient(RegisteredAnimals, RegisteredClients);
                    GoBackToMenu();
                    break;
                case "7":
                    GenerateNewAppointment(RegisteredClients, ServiceList);
                    GoBackToMenu();
                    break;
                case "8":
                    PrinterUtility.GenerateReport(AppointmentHistory);
                    GoBackToMenu();
                    break;
                default:
                    break;
            }
        }

        public void GoBackToMenu()
        {
            Console.WriteLine("Press enter to go back to main menu...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            RunClinicSim();
        }

        public static void AssociatePetToClient(List<Pet> PetList, List<Client> ClientList)
        {
            PrinterUtility.PrintRegisteredClients(ClientList);

            Client SelectedClient = null;

            while (SelectedClient == null)
            { 
                Console.WriteLine("Please select the ID of the client: ");
                int selectedClientId = Convert.ToInt32(Console.ReadLine());

                foreach (Client client in ClientList)
                {
                    if (selectedClientId == client.ID)
                    {
                        SelectedClient = client;
                    }
                }
            }

            PrinterUtility.PrintRegisteredAnimals(PetList);
            Pet SelectedPet = null;

            while (SelectedPet == null)
            {
                Console.WriteLine("Please select the ID of the Pet: ");
                int SelectedPetID = Convert.ToInt32(Console.ReadLine());

                foreach (Pet pet in PetList)
                {
                    if (SelectedPetID == pet.ID)
                    {
                        SelectedPet = pet;
                    }
                }
            }

            SelectedClient.Pet = SelectedPet;

            Console.WriteLine(SelectedPet.Name + " has been associated to " + SelectedClient.Name);
        }

        public static void AssociateEmployeeToService(List<Employee> EmployeeList, List<Services> ServiceList)
        {
            foreach (Services Service in ServiceList)
            {
                foreach (Employee Employee in EmployeeList)
                {
                    if ((Service.Name == "Check-up" || Service.Name == "Surgery") && Employee.Job == "Doctor")
                    {
                        Service.ServiceEmployees.Add(Employee);
                    } else if (Service.Name == "Grooming" && Employee.Job == "Groomer")
                    {
                        Service.ServiceEmployees.Add(Employee);
                    } else if (Service.Name == "Clinical Analysis" && Employee.Job == "Nurse")
                    {
                        Service.ServiceEmployees.Add(Employee);
                    } 
                    
                }
            }
        }

        public void GenerateNewAppointment(List<Client> ClientList, List<Services> ServiceList)
        {
            PrinterUtility.PrintRegisteredClients(ClientList);

            Client SelectedClient = null;

            while (SelectedClient == null)
            {
                Console.WriteLine("Please select the ID of the client: ");
                int SelectedClientId = Convert.ToInt32(Console.ReadLine());

                foreach (Client Client in RegisteredClients)
                {
                    if (SelectedClientId == Client.ID)
                    {
                        SelectedClient = Client;
                    }
                }
            }

            Console.Clear();

            PrinterUtility.PrintServices(ServiceList);

            Services SelectedService = null;

            while (SelectedService == null)
            {
                Console.WriteLine("Please select the service: ");
                string SelectedServiceName = Console.ReadLine();

                foreach (Services Service in ServiceList)
                {
                    if (SelectedServiceName == Service.Name)
                    {
                        SelectedService = Service;
                    }
                }
            }

            Employee SelectedEmployee = null;

            while (SelectedEmployee == null)
            {
                Console.WriteLine("Finally, please select our health professional's ID according to your time availability");
                int SelectedEmployeeID = Convert.ToInt32(Console.ReadLine());

                foreach (Employee Employee in SelectedService.ServiceEmployees)
                {
                    if (Employee.ID == SelectedEmployeeID)
                    {
                        SelectedEmployee = Employee;
                    }
                }
            }

            Console.WriteLine("Generating appointment...");
            AppointmentHistory.Add(new Appointment(SelectedClient, SelectedClient.Pet, SelectedEmployee, SelectedService));
        }

    }
}
