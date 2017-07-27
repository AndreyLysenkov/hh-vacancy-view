using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.ViewModel
{
    public class ViewModel
    {

        public enum Experience
        {
            DoesNotMatter,
            NoExperience,
            Between1And3,
            Between3And6,
            MoreThan6
        }

        private SiteApi api;

        public ViewModel()
        {
            this.api = new SiteApi();
        }

        private static string ExperienceEnumToParametr(Experience experience)
        {
            // Do not like this todo: NB
            string result = experience.ToString();
            result = result[0].ToString().ToLower() + result.Substring(1);
            return result;
        }

        // isTownOnly - если true - осуществляет фильтрацию по городу Калуга
        public Search SearchVacancy(string text, Experience experience, bool isTownOnly)
        {
            // TODO: строковый запрос сделать url save (sort of speek)
            SiteApi api = new SiteApi();
            List<Tuple<string, string>> arguments = new List<Tuple<string, string>>();
            // Do not like this todo: NB
            arguments.Add(Tuple.Create("text", text));
            if (isTownOnly)
                arguments.Add(Tuple.Create("area", "43"));
            arguments.Add(Tuple.Create("currency_code", "RUR"));
            arguments.Add(Tuple.Create("experience", ViewModel.ExperienceEnumToParametr(experience)));
            arguments.Add(Tuple.Create("order_by", "publication_time"));
            arguments.Add(Tuple.Create("items_on_page", "10"));
            Model.SearchParse searchResult = api.SearchVacancy(arguments.ToArray());
            return (Search)searchResult;
        }

    }
}
