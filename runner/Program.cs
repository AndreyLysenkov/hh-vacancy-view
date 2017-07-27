using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vacancy.Core;

namespace Vacancy.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteApi api = new SiteApi();
            SearchParse searchResult = api.SearchVacancy(
                Tuple.Create("text", "c%23+developer"),
                Tuple.Create("area", "43"),
                Tuple.Create("currency_code", "RUR"),
                Tuple.Create("experience", "between1And3"),
                Tuple.Create("order_by", "publication_time"),
                Tuple.Create("items_on_page", "20")
                );
            // break point на следующей строчке для просмотра результатов
            Console.WriteLine(searchResult);
            Console.ReadLine();
        }
    }
}
