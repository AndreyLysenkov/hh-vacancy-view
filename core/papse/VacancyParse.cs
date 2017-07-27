using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core
{
    public class VacancyParse
    {

        public string Id;

        public string Name;

        public string Url;

        public AreaParse Area;

        public SalaryParse Salary;

        public SnippetParse Snippet;

        public string Created_At;

        public string Published_At;

        public string Apply_Alternate_Url;

        public string Alternate_Url;

        public string[] Relations;

        public EmployerParse Employer;

        public bool Response_Letter_Required;

        public AdressParse Adress;

        public string Departament;

        public TypeParse Type;

    }
}
