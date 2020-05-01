using System;
using System.Collections.Generic;

namespace A5
{
    public class Doctors<TDoctor> where TDoctor : IPerson, IDoctor
    {
        List<TDoctor> Doctor = new List<TDoctor>();
        public void AddDoctor(TDoctor tdoctor)
        {
            Doctor.Add(tdoctor);
        }
        public List<string> ListOfRecoveredPatients()
        {
            List<string> patients = new List<string>();
            foreach(TDoctor d in Doctor)
            {
                foreach(Patient p in d.patients)
                {
                    if (p.Recovered)
                    {
                        patients.Add($"{p.Firstname} {p.Lastname}");
                    }
                }
            }
            return patients;
        }
        public string[] SortDoctors()
        {
            TDoctor[] td = Doctor.ToArray();
            Array.Sort(td);

            string[] res = new string[Doctor.Count];
            int i = 0;
            foreach(TDoctor d in td)
                res[i++] = d.Firstname + " " + d.Lastname;

            return res;
        }
    }
}
