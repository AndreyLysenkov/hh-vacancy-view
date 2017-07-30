using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{

    public class Employer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name;

        public string Url;

        public bool IsTrusted;

        public string LogoUrl;

        public bool HasLogo
            => this.LogoUrl != null;

        public string VacanciesUrl;

        public static explicit operator Employer(EmployerParse employer)
        {
            Employer result = new Employer();
            result.Name = employer.Name;
            result.Url = employer.Alternative_Url;
            result.IsTrusted = employer.Trusted;
            result.VacanciesUrl = employer.Vacancies_Url;
            result.LogoUrl = employer.Logo_Urls?.Original;

            return result;
        }

    }

}
