using System.Collections.Generic;
using TrabalhoClinicaVeterinaria.Clinic;
using TrabalhoClinicaVeterinaria.People;
using TrabalhoClinicaVeterinaria.Helpers;

namespace TrabalhoClinicaVeterinaria.Generators
{
    public static class ClinicGenerator
    {
        public static void GenerateServices(List<Services> ServiceList)
        {
            ServiceList.Add(new Services("Check-up", 20.0, 1, "None"));
            ServiceList.Add(new Services("Surgery", 150.0, 4, "Anaesthesia"));
            ServiceList.Add(new Services("Grooming", 15.0, 1, "None"));
            ServiceList.Add(new Services("Clinical Analysis", 30.0, 1, "None"));
        }

        public static void GenerateEmployees(List<Employee> EmployeeList)
        {
            EmployeeList.Add(new Employee("John Doe", 918237423, "Filler addr1", "Doctor", IDHelper.GenerateID(), "9:00 - 13:00"));
            EmployeeList.Add(new Employee("Mary Sue", 918233223, "Filler addr2", "Doctor", IDHelper.GenerateID(), "10:00 - 12:00" ));
            EmployeeList.Add(new Employee("Mike Law", 728783212, "Filler addr3", "Groomer", IDHelper.GenerateID(), "16:00 - 18:00" ));
            EmployeeList.Add(new Employee("Larry John", 289374621, "Filler addr4", "Nurse", IDHelper.GenerateID(), "8:00 - 12:00"));
        }
    }
}
