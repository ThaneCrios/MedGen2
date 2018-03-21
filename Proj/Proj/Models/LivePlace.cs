using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class LivePlace
    {
        public int Id { get; set; }
        public string CityType { get; set; } //тип населённого пункта
        public string CityName { get; set; } //название населенного пункта
        public string Republic { get; set; } //Республика
        public string District { get; set; } // район, округ 
        public int Population { get; set; } //общее население
        public int PopulationChildren { get; set; } // детское население

        public LivePlace(string s, string s2, string s3, string s4, int a, int b)
        {
            CityType = s;
            CityName = s2;
            Republic = s3;
            District = s4;
            Population = a;
            PopulationChildren = b;
        }
    }
}
