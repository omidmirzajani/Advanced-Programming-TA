using System.Collections.Generic;

namespace A5
{
    public interface IDoctor
    {
        string Field { get; set; }
        long Salary { get; set; }
        string University { get; set; }

        List<Patient> patients { get; set; }
        string Work();

        void Acceptable(Patient p);
    }
}
