using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{

    public class Student
    {
        public string Name { get; set; }
        public string Matricule { get; set; }
        public string Contact { get; set; }
        public string School { get; set; }
        public string PlaceofBirth { get; set; }
        public string Birthdate { get; set; }
        public string Mail { get; set; }

        public Student(string name, string matricule, string contact, string school, string placeofBirth, string birthdate, string mail)
        {
            Name = name;
            Matricule = matricule;
            Contact = contact;
            School = school;
            PlaceofBirth = placeofBirth;
            Birthdate = birthdate;
            Mail = mail;
        }

        public override bool Equals(object obj)
        {
            return obj is Student etudiant &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
