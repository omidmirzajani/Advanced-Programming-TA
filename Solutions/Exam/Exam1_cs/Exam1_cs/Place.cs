using System;

namespace Exam1_cs
{
    public class Place : ILocatable
    {
        public Place(string name,long x, long y, long z)
        {
            Name = name;
            X = x;
            Y = y;
            Z = z;
        }
        public string Name { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }

        public long Distance(ILocatable locatable)
        {
            long disX = (locatable.X - X) * (locatable.X - X);
            long disY = (locatable.Y - Y) * (locatable.Y - Y);
            long disZ = (locatable.Z - Z) * (locatable.Z - Z);
            return (long)Math.Sqrt(disX + disY + disZ);
        }
    }
}
