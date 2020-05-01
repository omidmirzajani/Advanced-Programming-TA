using System;
using System.Collections.Generic;

namespace A6
{
    public class GeneralPractitioner : IPerson, IDoctor,IComparable<GeneralPractitioner>
    {
        public GeneralPractitioner(string fitstname, string lastname, string field, long salary, string university, List<Patient> patients=null)
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
        public static GeneralPractitioner operator +(GeneralPractitioner g, Patient p)
        {
            if (g.patients == null)
                g.patients = new List<Patient>();
            if (g.ContainKeywords(p.Disease) && !g.patients.Contains(p))
                g.patients.Add(p);
            return g;
        }

        public static bool operator >(GeneralPractitioner g1, GeneralPractitioner g2)
        {
            int rate1 = Convert.ToInt32(g1.University.Split()[1]);
            int rate2 = Convert.ToInt32(g2.University.Split()[1]);

            return rate1 > rate2;
        }
        public static bool operator <(GeneralPractitioner g1, GeneralPractitioner g2)
        {
            int rate1 = Convert.ToInt32(g1.University.Split()[1]);
            int rate2 = Convert.ToInt32(g2.University.Split()[1]);

            return rate1 < rate2;
        }

        private bool ContainKeywords(string desease)
        {
            if (desease.Contains("Cough"))
                return true;
            if (desease.Contains("Sneezing"))
                return true;
            if (desease.Contains("Sore throat"))
                return true;
            return false;
        }

        public string GraduatedFrom()
        {
            return $"{Firstname} {Lastname} is graduated from {University.Split()[0]}";
        }

        public string Work()
        {
            return $"This General Practitioner works on {Field}";
        }

        public int CompareTo(GeneralPractitioner other)
        {
            double rateThis = RecoveredPatients(this);
            double rateOther = RecoveredPatients(other);

            if (rateOther != rateThis)
                return rateThis.CompareTo(rateOther);
            return this.Firstname.CompareTo(other.Firstname);
        }
        private double RecoveredPatients(GeneralPractitioner dentist)
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
