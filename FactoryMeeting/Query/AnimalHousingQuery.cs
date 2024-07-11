using FactoryMeeting.Enums;
using FactoryMeeting.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMeeting.Query
{
    public class AnimalHousingQuery
    {
        public double? Flaeche { get; set; }

        public AnimalHousingRequests AnimalHousingRequests { get; set; }
    }
}
