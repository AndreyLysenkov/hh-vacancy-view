using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{

    public class Vacancy : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Id;

        public string Name;

        public Salary Salary;

        public string Requirement;

        public string Responsibility;

        public bool IsPremium;

        public string Url;

        public string ApplyUrl;

        public DateTime Created;

        public DateTime Published;

        public bool IsResponseRequired;

        public Employer Employer;

        public Adress Adress;


        public static explicit operator Vacancy(VacancyParse vacancy)
        {
            Vacancy result = new Vacancy();
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

            result.Adress = vacancy.Adress != null ? (Adress)vacancy.Adress : null;
            result.Employer = (Employer)vacancy.Employer;
            result.Salary = vacancy.Salary != null ? (Salary)vacancy.Salary : null;

            return result;
        }


    }

}
