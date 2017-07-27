using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.View;

using Vacancy.Core;

namespace Vacancy.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            SearchView searchCSharp = model.Search("c%23+developer",
                experience: Model.Experience.Between1And3,
                isTownOnly: true);
            // break point на следующей строчке для просмотра результатов
            Console.WriteLine(searchCSharp);
            Console.ReadLine();
        }
    }
}
