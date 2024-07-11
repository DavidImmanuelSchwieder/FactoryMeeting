using FactoryMeeting.Enums;
using FactoryMeeting.Factories;
using FactoryMeeting.Query;
using FactoryMeeting.Types;
using System.Runtime.InteropServices;

namespace FactoryMeeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimalHousing tiergehege = AnimalHousingFactory.create<Tiergehege>();

            IAnimalHousing aquarium = AnimalHousingFactory.create<Aquarium>();

            List<AnimalHousingQuery> queries = new List<AnimalHousingQuery>();
            queries.Add(new AnimalHousingQuery()
            {
                Flaeche = 15,
                AnimalHousingRequests = Enums.AnimalHousingRequests.Aquarium
            });
            queries.Add(new AnimalHousingQuery()
            {
                Flaeche = 1.5,
                AnimalHousingRequests = Enums.AnimalHousingRequests.Tiergehege
            });
            queries.Add(new AnimalHousingQuery()
            {
                Flaeche = 11.5,
                AnimalHousingRequests = Enums.AnimalHousingRequests.Vogelpark
            });

            List<IAnimalHousing> ah = new List<IAnimalHousing>();
            foreach(AnimalHousingQuery aq in queries)
            {
                if (aq.AnimalHousingRequests == Enums.AnimalHousingRequests.Aquarium)
                {
                    ah.Add(AnimalHousingFactory.create<Aquarium>(aq.Flaeche));
                }
                if (aq.AnimalHousingRequests == Enums.AnimalHousingRequests.Tiergehege)
                {
                    ah.Add(AnimalHousingFactory.create<Tiergehege>(aq.Flaeche));
                }
                if (aq.AnimalHousingRequests == Enums.AnimalHousingRequests.Vogelpark)
                {
                    ah.Add(AnimalHousingFactory.create<Vogelpark>(aq.Flaeche));
                }
            }

            Console.WriteLine("Finished");



        }
    }
}
