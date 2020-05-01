using System;
using System.Collections.Generic;

namespace A6
{
    public class Dentist : IPerson, IDoctor,IComparable<Dentist>
    {
        public Dentist(string fitstname, string lastname, string field, long salary, string university, List<Patient> patients = null)
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

        public static Dentist operator +(Dentist d, Patient p)
        {
            if (d.patients == null)
                d.patients = new List<Patient>();
            if (d.ContainKeywords(p.Disease) && !d.patients.Contains(p))
                d.patients.Add(p);
            return d;
        }
        public static bool operator >(Dentist d1, Dentist d2)
        {
            return d1.Salary > d2.Salary;
        }
        public static bool operator <(Dentist d1, Dentist d2)
        {
            return d1.Salary < d2.Salary;
        }
        private bool ContainKeywords(string desease)
        {
            if (desease.Contains("Toothache"))
                return true;
            if (desease.Contains("Teeth"))
                return true;
            if (desease.Contains("Dental"))
                return true;
            return false;
        }
        public string GraduatedFrom()
        {
            return $"{Firstname} {Lastname} is graduated from {University.Split()[0]}";
        }

        public string Work()
        {
            return $"This Dentist works on {Field}";
        }

        public int CompareTo(Dentist other)
        {
            double rateThis = RecoveredPatients(this);
            double rateOther = RecoveredPatients(other);

            if(rateOther!=rateThis)
                return rateThis.CompareTo(rateOther);
            return this.Firstname.CompareTo(other.Firstname);
        }

        private double RecoveredPatients(Dentist dentist)
        {
            double k = 0;
            foreach(Patient p in dentist.patients)
            {
                if (p.Recovered)
                    k++;
            }
            return k / dentist.patients.Count;
        }
    }
}
