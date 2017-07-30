using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy.Core.Model
{
    public class VacancyParse
    {

        public string Id;

        public string Description;

        public string Branded_Description;

        public KeySkillParse[] Key_Skills;

        public ScheduleParse Schedule;

        public bool Accept_Handicapped;

        public ExperienceParse Experience;

        public AdressParse Adress;

        public string Alternate_Url;

        public string Apply_Alternate_Url;

        public string Code;

        public DepartmentParse Department;

        public EmploymentParse Employment;

        public SalaryParse Salary;

        public bool Archived;

        public string Name;

        public AreaParse Area;

        public DateTime Published_At;

        public EmployerParse Employer;

        public bool Response_Letter_Required;

        public TypeParse Type;

        public string Response_Url;

        public TestParse Test;

        public SpecializationParse Specialization;

        public ContactsParse Contacts;

        public BillingTypeParse Billing_Type;

        public bool Allow_Messages;

        public bool Premium;

        public string Url;

        public SnippetParse Snippet;

        public DateTime Created_At;

    }
}
