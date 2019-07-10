using System;

namespace OC_Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            foreach (string jour in jours)
            {
                if (jour == "Mercredi")
                {
                    jours.Remove(jour);
                }
            }
        }
    }
}
