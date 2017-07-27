using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Parse;

namespace Vacancy.Core.View
{

    public class EmployerView
    {

        public string Name;

        public string Url;

        public bool IsTrusted;

        public string LogoUrl;

        public bool HasLogo
            => this.LogoUrl != null;

        public string VacanciesUrl;

        public static explicit operator EmployerView(EmployerParse employer)
        {
            EmployerView result = new EmployerView();
            result.Name = employer.Name;
            result.Url = employer.Alternative_Url;
            result.IsTrusted = employer.Trusted;
            result.VacanciesUrl = employer.Vacancies_Url;
            result.LogoUrl = employer.Logo_Urls?.Original;

            return result;
        }

    }

}
