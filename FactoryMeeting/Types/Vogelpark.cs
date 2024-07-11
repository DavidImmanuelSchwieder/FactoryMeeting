using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeeting.Types
{
    public class Vogelpark : IAnimalHousing
    {
        public double? Flaeche { get; set; }


        public Vogelpark() { }
        public Vogelpark(double? fleache) 
        {
            Flaeche = fleache;
        }

    }
}
