using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoClinicaVeterinaria.Clinic;
using TrabalhoClinicaVeterinaria.Generators;

namespace GeneratorTesting
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void List_Of_Services_Is_Not_Null()
        {
            List<Services> ServicesList = new();
            ClinicGenerator.GenerateServices(ServicesList);

            foreach (Services service in ServicesList)
            {
                Assert.IsNotNull(service);
            }
        }

        [TestMethod]
        public void List_Of_Services_Has_Object_Of_Type_Services()
        {
            List<Services> ServicesList = new();
            ClinicGenerator.GenerateServices(ServicesList);

            foreach (Services service in ServicesList)
            {
                Assert.IsInstanceOfType(service, typeof(Services));
            } 
        }
    }
}
