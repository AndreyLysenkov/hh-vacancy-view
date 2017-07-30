using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{

    public class Search : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Vacancy> Vacancies;

        public string Url;

        public static explicit operator Search(SearchParse searchResult)
        {
            Search result = new Search();
            result.Url = searchResult.Alternate_Url;
            VacancyParse[] vacancyList = searchResult.items;
            result.Vacancies = new List<Vacancy>();
            foreach (var vacancy in vacancyList)
            {
                result.Vacancies.Add((Vacancy)vacancy);
            }
            return result;
        }

    }

}
