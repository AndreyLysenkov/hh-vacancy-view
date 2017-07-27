using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Parse;

namespace Vacancy.Core.View
{
    public class AdressView
    {

        public string Street;

        public string Building;

        public string Description;

        public AdressCoordinatesView Coordinates;

        public static explicit operator AdressView(AdressParse adress)
        {
            AdressView result = new AdressView();

            result.Street = adress.Street;
            result.Building = adress.Building;
            result.Description = adress.Description;
            result.Coordinates = new AdressCoordinatesView(adress.Lat, adress.Lng);

            return result;
        }


    }
}
