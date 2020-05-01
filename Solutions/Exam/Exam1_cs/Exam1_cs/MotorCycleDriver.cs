using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Exam1_cs
{
    public class MotorCycleDriver : ILocatable, IPerson, IDriver,IComparable<MotorCycleDriver>
    {
        public MotorCycleDriver(string name, long x, long y, long z, Color color)
        {
            X = x;
            Y = y;
            Z = z;
            Firstname = name.Split()[0];
            Lastname = name.Split()[1];
            Color = color;
            History = new List<Traffic>();
        }
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Color Color { get; set; }
        public List<Traffic> History { get; set; }

        public long Distance(ILocatable locatable)
        {
            long disX = (locatable.X - X) * (locatable.X - X);
            long disY = (locatable.Y - Y) * (locatable.Y - Y);
            long disZ = (locatable.Z - Z) * (locatable.Z - Z);
            return (long)Math.Sqrt(disX + disY + disZ);
        }
        public string VehicleColor()
        {
            return $"{Firstname} {Lastname} has a {Color.Name.ToLower()} motor cycle!";
        }
        public void GoToTarget(Customer c, ILocatable target)
        {
            if (c.Distance(target) * 3500 > c.AccountBalance)
            {
                throw new StackOverflowException();
            }
            else
            {
                X = c.X;
                Y = c.Y;
                Z = c.Z;

                c.AccountBalance -= this.Distance(target) * 3500;

                X = target.X;
                Y = target.Y;
                Z = target.Z;

                c.X = target.X;
                c.Y = target.Y;
                c.Z = target.Z;
            }
        }

        public int CompareTo(MotorCycleDriver other)
        {
            return this.Lastname.CompareTo(other.Lastname);
        }
    }
}
