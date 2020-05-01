using System.Collections.Generic;

namespace A6
{
    public interface IDoctor
    {
        string Field { get; set; }
        long Salary { get; set; }
        string University { get; set; }

        List<Patient> patients { get; set; }
        string Work();

    }
}
