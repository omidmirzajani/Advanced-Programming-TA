using System;
using System.Collections.Generic;
using System.Drawing;

namespace Exam1_cs
{
    public class CarDriver : ILocatable, IPerson, IDriver,IComparable<CarDriver>
    {
        public CarDriver(string name, long x, long y, long z, Color color)
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
        public string VehicleColor()
        {
            return $"{Firstname} {Lastname} has a {Color.Name.ToLower()} car!";
        }
        public long Distance(ILocatable locatable)
        {
            long disX = (locatable.X - X) * (locatable.X - X);
            long disY = (locatable.Y - Y) * (locatable.Y - Y);
            long disZ = (locatable.Z - Z) * (locatable.Z - Z);
            return (long)Math.Sqrt(disX + disY + disZ);
        }
        public void GoToTarget(Customer c, ILocatable target)
        {
            if (c.Distance(target) * 3000 > c.AccountBalance)
            {
                throw new StackOverflowException();
            }
            else
            {
                X = c.X;
                Y = c.Y;
                Z = c.Z;

                c.AccountBalance -= this.Distance(target) * 3000;

                X = target.X;
                Y = target.Y;
                Z = target.Z;

                c.X = target.X;
                c.Y = target.Y;
                c.Z = target.Z;
            }
        }

        public int CompareTo(CarDriver other)
        {
            long rateThis = AllDistance(this);
            long rateOther = AllDistance(other);
            return rateThis.CompareTo(rateOther);
        }

        private long AllDistance(CarDriver other)
        {
            long res = 0;
            foreach (Traffic t in other.History)
                res += t.source.Distance(t.target);
            return res;
        }
        public static CarDriver operator +(CarDriver car,Traffic traffic)
        {
            car.History.Add(traffic);
            return car;
        }
        
    }
}
