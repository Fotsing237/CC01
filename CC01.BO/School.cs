using System.Collections.Generic;

namespace CC01.BO
{
    public class School
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

        public School()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is School school &&
                   Acronym == school.Acronym;
        }

        public override int GetHashCode()
        {
            return -1483844518 + EqualityComparer<string>.Default.GetHashCode(Acronym);
        }
    }
}