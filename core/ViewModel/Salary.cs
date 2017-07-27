using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{
    public class Salary
    {

        public SalaryRange Range;

        public bool? Gross;

        public static explicit operator Salary(SalaryParse salary)
        {
            Salary result = new Salary();
            result.Gross = salary.Gross;
            result.Range = new SalaryRange(salary.From, salary.To);
            return result;
        }

    }
}
