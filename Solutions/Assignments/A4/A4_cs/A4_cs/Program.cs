using System;

namespace A4_cs
{
    public enum Config
    {
        Graphic=1,
        Memory=2,
        Cpu=4
    }
    public class MemoryHeap
    {
        public byte[] Data;

        public void Allocate(int bytes)
        {
            Data = new byte[bytes];
        }
        public void DeAllocate()
        {
            Data = new byte[0];
        }
    }

    public struct Struct_Size5
    {
        byte b1;
        byte b2;
        byte b3;
        byte b4;
        byte b5;
    }

    public struct Struct_Size12
    {
        int i1;
        int i2;
        int i3;
    }

    public struct Struct_Size10
    {
        Struct_Size5 sc5_1;
        Struct_Size5 sc5_2;
    }

    public struct Struct_Size50
    {
        Struct_Size10 sc5_1;
        Struct_Size10 sc5_2;
        Struct_Size10 sc5_3;
        Struct_Size10 sc5_4;
        Struct_Size10 sc5_5;
    }

    public struct Struct_Size105
    {
        Struct_Size50 sc5_1;
        Struct_Size50 sc5_2;
        Struct_Size5 sc;
       
    }

    public class Memory
    {
        public int? Capacity;
        public int? Pins;
        public string Type;

        public Memory(int? capacity, int? pins, string type)
        {
            Capacity = capacity;
            Pins = pins;
            Type = type;
        }
    }
    public class Graphic
    {
        public int? Size;
        public string Coprocessor;
        public string Type;

        public Graphic(int? size, string coprocessor, string type)
        {
            Size = size;
            Coprocessor = coprocessor;
            Type = type;
        }
    }
    public class Cpu
    {
        public string Model;
        public double? Weight;
        public string Speed;

        public Cpu(string model, double? weight, string speed)
        {
            Model = model;
            Weight = weight;
            Speed = speed;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string ChooseBest(Config c)
        {
            bool f1 = ((c & Config.Graphic) == Config.Graphic);
            bool f2 = ((c & Config.Memory) == Config.Memory);
            bool f3 = ((c & Config.Cpu) == Config.Cpu);

            if (f1 && f2 && f3)
                return "Excellent";
            if (f2 && (f1 || f3))
                return "Very Good";
            if (f2 && !(f1 || f3))
                return "Good";
            return "Not Bad";
        }
        public static void SwapConfigs(object o1, object o2)
        {
            if(o1 is Memory)
            {
                Memory m1 = (Memory)o1;
                Memory m2 = (Memory)o2;

                int? tmpSize = m2.Capacity;
                m2.Capacity = m1.Capacity;
                m1.Capacity = tmpSize;

                int? tmpPins = m2.Pins;
                m2.Pins = m1.Pins;
                m1.Pins = tmpPins;

                string tmpType = m2.Type;
                m2.Type = m1.Type;
                m1.Type = tmpType;

                o2 = (object)m2;
            }
            if (o1 is Graphic)
            {
                Graphic g1 = (Graphic)o1;
                Graphic g2 = (Graphic)o2;

                int? tmpSize = g2.Size;
                g2.Size = g1.Size;
                g1.Size = tmpSize;

                string tmpType = g2.Type;
                g2.Type = g1.Type;
                g1.Type = tmpType;

                string tmpCoprocessor = g2.Coprocessor;
                g2.Coprocessor = g1.Coprocessor;
                g1.Coprocessor = tmpCoprocessor;

                o2 = (object)g2;
            }
            if (o1 is Cpu)
            {
                Cpu c1 = (Cpu)o1;
                Cpu c2 = (Cpu)o2;

                string tmpModel = c2.Model;
                c2.Model = c1.Model;
                c1.Model = tmpModel;

                string tmpSpeed = c2.Speed;
                c2.Speed = c1.Speed;
                c1.Speed = tmpSpeed;

                double? tmpWeight = c2.Weight;
                c2.Weight = c1.Weight;
                c1.Weight = tmpWeight;

                o2 = (object)c2;
            }
        }
    }
}
