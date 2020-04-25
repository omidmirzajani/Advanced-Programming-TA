using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commanders = new string[4] { "Joe","Cole","Bryant","James" };
            Random random = new Random();
            for (int i = 1; i <= 30; i++)
            {
                string path = $@"..\..\Input\Text{i}.txt";

                int commander = random.Next(0, 3);
                int infantries = random.Next(20, 40)*10;
                int panzers = random.Next(2, 16);
                int bombers = random.Next(2, 6);
                if (panzers > 10)
                    panzers = 0;
                if (bombers > 3)
                    bombers = 0;

                int rnd = random.Next(6, 8);

                string[] targets = new string[6] {"Land", "Residental Area", "Highway", "Millitary Base", "Airport", "Byway" };
                string lineTarget = "Target : ";
                int target = random.Next(0, 5);
                lineTarget += targets[target];

                string lineMillitary = "Militaries : ";
                if (panzers != 0)
                    lineMillitary += $"{panzers} panzers,";
                if(bombers!=0)
                    lineMillitary += $"{bombers} bombers,";
                lineMillitary += $"{infantries} infantries";

                List<string> Lines = new List<string>();
                Lines.Add($"{rnd} A.M. February");
                Lines.Add($"From : Commander-in-chief {commanders[commander]}");
                Lines.Add(lineTarget);
                Lines.Add(lineMillitary);
                Lines.Add($"Dispatch as soon as possible");
                Lines.Add($"Heil Wizard");

                File.WriteAllLines(path, Lines);
            }
            for (int i = 1; i <= 30; i++)
            {
                long[] numRand = NumGenerator();
                long[] print = RandomGenerator(26);
                string path = $@"..\..\Input\Text{i}.txt";
                File.Delete($@"..\..\Output\Text{i}.txt");
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string s = Coded(line, print,numRand) + " ";
                    File.AppendAllLines($@"..\..\Output\Text{i}.txt", new string[1] { s });
                }
            }

        }

        public static long[] NumGenerator()
        {
            Random random = new Random();
            long[] res = new long[10];
            int rnd = random.Next(0, 9);
            int k = 0;
            for (int i = rnd + 1; i < 10; i++)
            {
                k++;
                res[i] = i - rnd ;
            }
            for (int i = 0; i < rnd; i++)
                res[i] = k + i+1;
            return res;
        }

        private static string Coded(string s,long[] print, long[] numRand)
        {
            string res = "";
            foreach(char c in s)
            {
                int t = (int)c;
                if (t >= 97 && t <= 122)
                    res += (char)(97 + print[t - 97]);
                else if (t >= 65 && t <= 90)
                    res += (char)(65 + print[t - 65]);
                else if (t >= 48 && t <= 57)
                    res += (char)(48 + numRand[t - 48]);
                else
                    res += c;
            }
            return res;
        }

        public static long[] RandomGenerator(int t)
        {
            Random random = new Random();
            long[] res = new long[t];
            for(int i=0;i<t;i++)
            {
                var r = random.Next(0,t);
                while(res[r]!=0)
                {
                    r= random.Next(0, t);
                }
                res[r] = i;
            }
            return res;
        }
    }
}
