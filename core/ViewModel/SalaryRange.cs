using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.ViewModel
{

    public class SalaryRange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Minimum;

        public int Maximum;

        public bool HasMinimum;

        public bool HasMaximum;

        // указана ли заплата
        public bool IsSpecified
            => this.HasMaximum || this.HasMinimum;

        // NB todo
        //public bool IsFixed

        public SalaryRange(int? from, int? to)
        {
            this.Minimum = from ?? 0;
            this.Maximum = to ?? 0;
            this.HasMaximum = from != null;
            this.HasMinimum = to != null;
        }

    }

}
