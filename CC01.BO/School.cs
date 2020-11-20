using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    class School
    {
        public string Acronym { get; set; }
        public string Location { get; set; }
        public string Schoolname { get; set; }
        public string Logo { get; set; }

        public School(string acronym, string location, string schoolname, string logo)
        {
            Acronym = acronym;
            Location = location;
            Schoolname = schoolname;
            Logo = logo;
        }
    }
}
