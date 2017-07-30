using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{
    public class Adress : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
