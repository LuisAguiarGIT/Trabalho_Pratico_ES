using System;

namespace TrabalhoClinicaVeterinaria.Helpers
{
    public static class IDHelper
    {
        public static int GenerateID()
        {
            Random rnd = new();
            return 2000 + rnd.Next(0, 1000);
        }
    }
}
