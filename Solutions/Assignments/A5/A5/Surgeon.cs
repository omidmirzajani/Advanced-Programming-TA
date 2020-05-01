using System;
using System.Collections.Generic;

namespace A5
{
    public class Surgeon : IPerson, IDoctor,IComparable<Surgeon>
    {
        public Surgeon(string fitstname, string lastname, string field, long salary, string university, List<Patient> patients=null)
        {
            Firstname = fitstname;
            Lastname = lastname;
            Field = field;
            Salary = salary;
            University = university;
            this.patients = patients;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Field { get; set; }
        public long Salary { get; set; }
        public string University { get; set; }
        public List<Patient> patients { get; set; }
        

        public void Acceptable(Patient p)
        {
            if (patients == null)
                patients = new List<Patient>();
            if (ContainKeywords(p.Disease) && !patients.Contains(p))
                patients.Add(p);
        }
        private bool ContainKeywords(string desease)
        {
            if (desease.Contains("Cancer"))
                return true;
            if (desease.Contains("Appendix"))
                return true;
            if (desease.Contains("Kidney"))
                return true;
            return false;
        }
        public string GraduatedFrom()
        {
            return $"{Firstname} {Lastname} is graduated from {University}";
        }

        public string Work()
        {
            return $"This Surgeon works on {Field}";
        }

        public int CompareTo(Surgeon other)
        {
            double rateThis = RecoveredPatients(this);
            double rateOther = RecoveredPatients(other);

            if (rateOther != rateThis)
                return rateThis.CompareTo(rateOther);
            return this.Firstname.CompareTo(other.Firstname);
        }
        private double RecoveredPatients(Surgeon dentist)
        {
            double k = 0;
            foreach (Patient p in dentist.patients)
            {
                if (p.Recovered)
                    k++;
            }
            return k / dentist.patients.Count;
        }
    }
}
