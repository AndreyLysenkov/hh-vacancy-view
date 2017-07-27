using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Parse;

namespace Vacancy.Core.View
{

    public class VacancyView
    {

        public string Id;

        public string Name;

        public SalaryView Salary;

        public string Requirement;

        public string Responsibility;

        public bool IsPremium;

        public string Url;

        public string ApplyUrl;

        public DateTime Created;

        public DateTime Published;

        public bool IsResponseRequired;

        public EmployerView Employer;

        public AdressView Adress;


        public static explicit operator VacancyView(VacancyParse vacancy)
        {
            VacancyView result = new VacancyView();

            result.Id = vacancy.Id;
            result.Name = vacancy.Name;
            result.Requirement = vacancy.Snippet.Requirement;
            result.Responsibility = vacancy.Snippet.Responsibility;
            result.IsPremium = vacancy.Premium;
            result.Url = vacancy.Alternate_Url;
            result.ApplyUrl = vacancy.Apply_Alternate_Url;
            result.Created = vacancy.Created_At;
            result.Published = vacancy.Published_At;
            result.IsResponseRequired = vacancy.Response_Letter_Required;

            result.Adress = (AdressView)vacancy.Adress;
            result.Employer = (EmployerView)vacancy.Employer;
            result.Salary = (SalaryView)vacancy.Salary;

            return result;
        }


    }

}
