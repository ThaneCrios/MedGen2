using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class Man
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public DateTime Date { get; set; }
        public string Sex { get; set; }
        public string BirthPlace { get; set; }
        public string StreetAdress { get; set; }
        public string CityAdress { get; set; }
        public string Nationality { get; set; }
        //public string Family
        public Man(string s, DateTime d, string s2, string s3, string s4, string s5, string s6)
        {
            Fio = s;
            Date = d;
            Sex = s2;
            BirthPlace = s3;
            StreetAdress = s4;
            CityAdress = s5;
            Nationality = s6;
        }
    }
}
