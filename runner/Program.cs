using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.ViewModel;

using Vacancy.Core;

namespace Vacancy.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewModel model = new ViewModel();
            Search searchCSharp = model.SearchVacancy("c%23+developer",
                experience: ViewModel.Experience.Between1And3,
                isTownOnly: true);
            // break point на следующей строчке для просмотра результатов
            Console.WriteLine(searchCSharp);
            Console.ReadLine();
        }
    }
}
