using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.ViewModel
{
    public class AdressCoordinates : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Lat;

        public double Lng;

        public bool IsSet;

        public AdressCoordinates(double? lat, double? lng)
        {
            this.Lat = lat ?? 0;
            this.Lng = lng ?? 0;
            this.IsSet = (lat != null) && (lng != null);
        }

        // TODO: заменить , на . по нормальному
        public string ToGoogleMapsLink()
            => $"https://www.google.ru/maps/@{this.Lat.ToString().Replace(',', '.')},{this.Lng.ToString().Replace(',', '.')},21z";

    }
}
