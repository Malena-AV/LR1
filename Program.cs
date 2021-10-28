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
        public string GetZnak()
        {
            if (ch * zn >= 0)
            {
                return "+";
            }
            else
            {
                return "-";
            }
        }
        public int this [int index]
        {
            get { return (index == 0) ? ch : zn; }
        }
        public delegate void Delegat(Drobe a, int b);
        public event Delegat MyEventCh;
        public event Delegat MyEventZn;
        public int Ch
        {
            get { return ch; }
            set { MyEventCh(this, value); ch = value; }
        }
        public int Zn
        {
            get { return zn; }
            set { MyEventZn(this, value); zn = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobe drobe1 = new Drobe(-1,2);
            Drobe drobe2 = new Drobe(3,4,7);
            Console.WriteLine(drobe1.GetZnak());
            drobe1.MyEventCh += MyMetod;
            drobe1.MyEventZn += MyMetod1;
            drobe1.Ch = 15;
            drobe1.Zn = 110;
            Drobe drobe3 = new Drobe(10);
            Console.WriteLine("+: " + (drobe1 + drobe2)[0] + "/" + (drobe1 + drobe2)[1]);
            Console.WriteLine("-: " + (drobe1 - drobe2)[0] + "/" + (drobe1 - drobe2)[1]);
            Console.WriteLine("*: " + (drobe1 * drobe2)[0] + "/" + (drobe1 * drobe2)[1]);
            Console.WriteLine("/: " + (drobe1 / drobe2)[0] + "/" + (drobe1 / drobe2)[1]);
            Console.WriteLine(drobe2.Delenye()); 
            Console.WriteLine(drobe1[0]+"/"+drobe1[1]);
            Console.WriteLine(drobe1.Ch + "/" + drobe1.Zn);
            Console.ReadKey();
        }
        public static void MyMetod(Drobe a, int b)
        {
            Console.WriteLine("изменился числитель");
        }
        public static void MyMetod1(Drobe a, int b)
        {
            Console.WriteLine("изменился знаменатель");
        }
    } 
}
