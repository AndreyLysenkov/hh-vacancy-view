using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Parse;

namespace Vacancy.Core.View
{
    public class SalaryView
    {

        public SalaryRangeView Range;

        public string Currency;

        public bool Gross;

        public static explicit operator SalaryView(SalaryParse salary)
        {
            SalaryView result = new SalaryView();

            result.Currency = salary.Currency;
            result.Gross = salary.Gross;

            result.Range = new SalaryRangeView(salary.From, salary.To);

            return result;
        }


    }
}
