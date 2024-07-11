using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMeeting.Types;

namespace FactoryMeeting.Factories
{
    public class AnimalHousingFactory : IAnimalHousingFactory
    {
        public static IAnimalHousing create<T>() where T : IAnimalHousing
        {
            if (typeof(T).IsAssignableFrom(typeof(Aquarium)))
            {
                return new Aquarium();
            }
            else if (typeof(T).IsAssignableFrom(typeof(Tiergehege)))
            {
                return new Tiergehege();
            }
            else if (typeof(T).IsAssignableFrom(typeof(Vogelpark)))
            {
                return new Vogelpark();
            }

            throw new NotImplementedException();
        }

        public static IAnimalHousing create<T>(double? flaeche) where T : IAnimalHousing 
        {
            if (typeof(T).IsAssignableFrom(typeof(Aquarium)))
            {
                return new Aquarium() { Flaeche = flaeche};
            }
            else if (typeof(T).IsAssignableFrom(typeof(Tiergehege)))
            {
                return new Tiergehege() { Flaeche = flaeche};
            }
            else if (typeof(T).IsAssignableFrom(typeof(Vogelpark)))
            {
                return new Vogelpark(flaeche);
            }
            throw new NotImplementedException();
        }
    }
}
