using System;
using System.Collections.Generic;

namespace Exam1_cs
{
    public class ManagementDrivers<TDriver> where TDriver:IDriver,IPerson,ILocatable
    {
        public TDriver[] Drivers;

        public void SortDrivers()
        {
            Array.Sort(Drivers);
        }
        public string[] WhereIsNow()
        {
            string[] result = new string[Drivers.Length];
            for(int i = 0; i < result.Length; i++)
            {
                result[i]= $"{Drivers[i].Firstname} is on {Drivers[i].X} situation.";
            }
            return result; 
        }

        public void NearestDriver(Customer c,Place p)
        {
            long min = long.MaxValue;
            long index = 0;
            for(int i = 0; i < Drivers.Length; i++)
            {
                if (Drivers[i].Distance(c) < min)
                {
                    index = i;
                    min = Drivers[i].Distance(c);
                }
            }
            Drivers[index].GoToTarget(c, p);
        }
    }
}
