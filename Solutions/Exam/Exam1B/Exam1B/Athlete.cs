using System.Collections;
using System.Collections.Generic;

namespace Exam1B
{
    public class Athlete : IPlayer
    {
        public string name { get; set; }
        public bool height { get; set; }
        public bool speed { get; set; }
        public Athlete(string name, bool height, bool speed)
        {
            this.name = name;
            this.height = height;
            this.speed = speed;
        }
        public string Post()
        {
            if(height && speed)
                return $"{name} is appropriate for basketball";
            if(height)
                return $"{name} is appropriate for volleyball";
            if (speed)
                return $"{name} is appropriate for running";
            return $"{name} is appropriate for wrestling";
        }

    }
}
