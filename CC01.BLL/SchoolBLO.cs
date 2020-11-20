using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class SchoolBLO
    {
        SchoolDAO schoolRepo;
        public SchoolBLO(string dbFolder)
        {
            schoolRepo = new SchoolDAO(dbFolder);
        }
        public void CreateSchool(School school)
        {
            schoolRepo.Add(school);
        }

        public void DeleteSchool(School school)
        {
            schoolRepo.Remove(school);
        }


        public IEnumerable<School> GetAllSchools()
        {
            return schoolRepo.Find();
        }


        public IEnumerable<School> GetByAcronym(string acronym)
        {
            return schoolRepo.Find(x => x.Acronym == acronym);
        }

        public IEnumerable<School> GetBy(Func<School, bool> predicate)
        {
            return schoolRepo.Find(predicate);
        }

        public void EditSchool(School oldSchool, School newSchool)
        {
            schoolRepo.Set(oldSchool, newSchool);
        }
    }
}
