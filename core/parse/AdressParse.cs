using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.Parse
{
    public class AdressParse
    {

        public string City;

        public string Street;

        public string Building;

        public string Description;

        public Double? Lat;

        public Double? Lng;

        public string Raw;

        // сделал dynamic - т.к. в Калуге нет метро, 
        // а значит и парсить метро бессмыслено
        public dynamic[] Metro_stations;
        
        public string Id;
        
    }
}
