using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoClinicaVeterinaria.Helpers;

namespace IDHelperTest
{
    [TestClass]
    public class IDGeneratorTest
    {
        [TestMethod]
        public void Generate_ID_Is_Not_Null()
        {
            int GeneratedID = IDHelper.GenerateID();

            Assert.IsNotNull(GeneratedID);
        }

        [TestMethod]
        public void Generates_ID_Generates_Number()
        {
            int GeneratedID = IDHelper.GenerateID();

            Assert.IsInstanceOfType(GeneratedID, typeof(int));
        }

    }
}
