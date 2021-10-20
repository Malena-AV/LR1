using System;

namespace ConsoleAppлр1
{
    class Drobe
    {
       int ch;
       int zn;
        public Drobe(int x, int y)
        {
            this.ch = x;
            this.zn = y;
        }
        public Drobe (int x)
        {
            this.ch = x;
            this.zn = 1;
        }
        public Drobe (int x, int y, int z)
        {
            this.ch = y*z+x;
            this.zn = y;
        }
        public double Delenye ()
        {
            return (double) (ch) / zn;
        }
        public static Drobe operator + (Drobe x, Drobe y)
        {
            return new Drobe(x.ch*y.zn + y.ch*x.zn, x.zn*y.zn);
        }
        public static Drobe operator - (Drobe x, Drobe y)
        {
            return new Drobe(x.ch * y.zn - y.ch * x.zn, x.zn * y.zn);
        }
        public static Drobe operator * (Drobe x, Drobe y)
        {
            return new Drobe(x.ch * y.ch, x.zn * x.zn);
        }
        public static Drobe operator / (Drobe x, Drobe y)
        {
            return new Drobe(x.ch *y.zn, x.zn*y.ch);
        }
        public static void GetDrobe(Drobe a)
        {
            Console.WriteLine(a.ch + "/" + a.zn);
        }
        public static void GetZnak(Drobe a)
        {
            if (a.ch * a.zn >= 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        public int this [int index]
        {
            get { return (index == 0) ? ch : zn; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobe drobe1 = new Drobe(-1,2);
            Drobe drobe2 = new Drobe(3,4);
            Console.WriteLine("Знак дроби drobe1: ");
            Drobe.GetZnak(drobe1);
            Console.WriteLine("Знак дроби drobe2: ");
            Drobe.GetZnak(drobe2);
            Console.WriteLine("Вызов по индексу: ");
            Console.WriteLine(drobe2[1]);
            Console.WriteLine("Операция с дробями: ");
            Drobe.GetDrobe(drobe1 - drobe2);
        }
    }
}
