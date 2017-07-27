using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Parse;

namespace Vacancy.Core.View
{

    public class SearchView
    {

        public List<VacancyView> Vacancies;

        public string Url;

        public static explicit operator SearchView(SearchParse searchResult)
        {
            SearchView result = new SearchView();
            result.Url = searchResult.Alternate_Url;
            VacancyParse[] vacancyList = searchResult.items;
            foreach (var vacancy in vacancyList)
            {
                //result.Vacancies.Add((VacancyView)vacancy);
            }
            return result;
        }

    }

}
