using System;
using System.Collections;
using System.Collections.Generic;

namespace Exam1_cs
{
    public class Customer : ILocatable, IPerson,IEnumerable<string>
    {
        public Customer(string name, long x, long y, long z, long accountBalance = 0)
        {
            X = x;
            Y = y;
            Z = z;
            Firstname = name.Split()[0];
            Lastname = name.Split()[1];
            AccountBalance = accountBalance;
            History = new List<Traffic>();
        }

        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }
        public string Firstname{ get; set; }
        public string Lastname { get; set; }
        public long AccountBalance { get; set; }
        public List<Traffic> History { get; set; }
        public static Customer operator +(Customer c,int value)
        {
            c.AccountBalance += value;
            return c;
        }
        public long Distance(ILocatable locatable)
        {
            long disX = (locatable.X - X) * (locatable.X - X);
            long disY = (locatable.Y - Y) * (locatable.Y - Y);
            long disZ = (locatable.Z - Z) * (locatable.Z - Z);
            return (long)Math.Sqrt(disX + disY + disZ);
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (Traffic t in History)
                yield return $"{t.source.Name}:{t.target.Name}";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Traffic t in History)
                yield return $"{t.source.Name}:{t.target.Name}";
        }
    }
}
