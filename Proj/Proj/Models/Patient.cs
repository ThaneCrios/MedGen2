using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string diagnosis { get; set; } // диагноз
        public int disability { get; set; } //инвалидность
        public string CardCode { get; set; } //Код карты
        public string TypeOfInheritance { get; set; } //тип наследования
        public string Notes { get; set; } //примечания
        public string OurNotOur { get; set; } //наш не наш

        public Man Man; 
        public int ManId { get;set; }
        public Patient()
        {
            Man = new Man("sdsadas", new DateTime(2018, 3, 2), "fag", "fdzz", "kgh", "kou", "kj");
            diagnosis = "sdafsdf";
            disability = 2;
            CardCode = "ashlkd";
            TypeOfInheritance = "jghjg";
            Notes = "fasd";
            OurNotOur = "yes";
        }
    }
}
