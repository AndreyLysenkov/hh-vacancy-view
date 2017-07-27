using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.View
{

    public class SalaryRangeView
    {

        public int Minimum;

        public int Maximum;

        public bool HasMinimum;

        public bool HasMaximum;

        // указана ли заплата
        public bool IsSpecified
            => this.HasMaximum || this.HasMinimum;

        // NB todo
        //public bool IsFixed

        public SalaryRangeView(int? from, int? to)
        {
            this.Minimum = from ?? 0;
            this.Maximum = to ?? 0;
            this.HasMaximum = from != null;
            this.HasMinimum = to != null;
        }

    }

}
