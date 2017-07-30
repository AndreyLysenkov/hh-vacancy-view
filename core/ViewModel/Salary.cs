using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Core.Model;

namespace Vacancy.Core.ViewModel
{
    public class Salary : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
