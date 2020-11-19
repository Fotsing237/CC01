using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Ecole
    {
        public string Acronym { get; set; }
        public string Location { get; set; }
        public string Schoolname { get; set; }
        public string Logo { get; set; }

        public Ecole(string acronym, string location, string schoolname, string logo)
        {
            Acronym = acronym;
            Location = location;
            Schoolname = schoolname;
            Logo = logo;
        }
    }
}
