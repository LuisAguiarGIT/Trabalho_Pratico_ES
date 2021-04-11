using System.Collections.Generic;
using TrabalhoClinicaVeterinaria.Clinic;

namespace TrabalhoClinicaVeterinaria.People
{
    public class Employee : Person
    {
        public List<Services> Services = new();
        public Employee(string EmployeeName, int EmployeeContact, string EmployeeAddress, string EmployeeJob, int Id, string EmployeeShift)
        {
            Name = EmployeeName;
            Contact = EmployeeContact;
            Address = EmployeeAddress;
            Job = EmployeeJob;
            ID = Id;
            Shift = EmployeeShift;
        }
        public override string Name { get; set; }

        public override int Contact { get; set; }

        public override string Address { get; set; }

        public override int ID { get; set; }

        public string Job { get; private set; }

        public string Shift { get; set; }

    }
}
