using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class Man
    { //Add-Migration Initial
        //Update-Database
        public int Id { get; set; }
        public string Fio { get; set; } // ФИО
        public DateTime Date { get; set; } // Дата рождения
        public string Sex { get; set; } // Пол
        public string BirthPlace { get; set; } // Место рождения(республика, округ и тд)
        public string StreetAdress { get; set; } // название улицы
        public string CityAdress { get; set; } // название города, села
        public string Nationality { get; set; } // национальность
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
        public Man()
        {

        }
    }
}
