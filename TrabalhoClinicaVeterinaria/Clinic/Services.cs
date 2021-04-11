using System.Collections.Generic;
using TrabalhoClinicaVeterinaria.People;

namespace TrabalhoClinicaVeterinaria.Clinic
{
    public class Services
    {
        public List<Employee> ServiceEmployees = new();
        public Services(string ServiceName, double ServicePrice, int ServiceDuration, string ServiceMedicine)
        {
            Name = ServiceName;
            Price = ServicePrice;
            Duration = ServiceDuration;
            Medicine = ServiceMedicine;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Duration { get; private set; }
        public string Medicine { get; private set; }

    }
}
