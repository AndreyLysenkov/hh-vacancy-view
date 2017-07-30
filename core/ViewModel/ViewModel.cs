using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Vacancy.Core.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public enum Experience
        {
            [Description("опыт работы не важен")]
            DoesNotMatter,
            [Description("опыта работы нет")]
            NoExperience,
            [Description("опыт работы от 1 до 3 лет")]
            Between1And3,
            [Description("опыт работы от 3 до 6 лет")]
            Between3And6,
            [Description("опыт работы более 6 лет")]
            MoreThan6
        }

        private SiteApi api;

        private string _keyWords;
        public string KeyWords
        {
            get
            {
                return _keyWords;
            }
            set
            {
                _keyWords = value;
                RaisePropertyChanged("KeyWords");
            }
        }
        private Experience _workExperience;
        public Experience WorkExperience
        {
            get
            {
                return _workExperience;
            }
            set
            {
                _workExperience = value;
                RaisePropertyChanged("WorkExperience");
            }
        }

        private bool _isTownOnly;
        public bool IsTownOnly
        {
            get
            {
                return _isTownOnly;
            }
            set
            {
                _isTownOnly = value;
                RaisePropertyChanged("IsTownOnly");
            }
        }

        public ViewModel()
        {
            this.api = new SiteApi();
            this.KeyWords = "ключевые слова";
            this.WorkExperience = Experience.DoesNotMatter;
            this.IsTownOnly = true;
        }

        public IList<Experience> ExperienceValueList
            => Enum.GetValues(typeof(Experience)).Cast<Experience>().ToList();

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

        public Search SearchVacancy()
            => this.SearchVacancy(this.KeyWords, this.WorkExperience, this.IsTownOnly);

    }
}
