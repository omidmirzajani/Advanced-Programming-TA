using System.Collections.Generic;
using System.Drawing;

namespace Exam1_cs
{
    public interface IDriver
    {
        Color Color { get; set; }
        List<Traffic> History { get; set; }
        void GoToTarget(Customer c, ILocatable target);

    }
}
