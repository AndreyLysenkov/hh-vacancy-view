using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{
    public class Adress
    {

        public string Street;

        public string Building;

        public string Description;

        public AdressCoordinates Coordinates;

        public static explicit operator Adress(AdressParse adress)
        {
            Adress result = new Adress();

            result.Street = adress.Street;
            result.Building = adress.Building;
            result.Description = adress.Description;
            result.Coordinates = new AdressCoordinates(adress.Lat, adress.Lng);

            return result;
        }


    }
}
