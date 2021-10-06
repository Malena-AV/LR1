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
            return (double) (ch) / (zn);
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


    }

    class Program
    {
        static void Main(string[] args)
        {
            Drobe drobe1 = new Drobe();
            Drobe drobe2 = new Drobe();
            double cumma = drobe1 + drobe2;
            Console.WriteLine(cumma);

        }
    }
}
