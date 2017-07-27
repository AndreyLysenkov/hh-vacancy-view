using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{

    public class Search
    {

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
