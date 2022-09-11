using System;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            MC mc = new MC();
            mc.a = 15;
            mc.b = 15;

            MC mc1 = new MC();
            mc1.a = 20;
            mc1.b = 30;
            mc1.ChangeNormal();
            MC.c = 36;
            MC.ChangeStatic();
        }
    }
    class MC
    {
       public int a;
       public int b;
       public static int c;

       public void ChangeNormal()
        {
            a = 20;
        }
       public static void ChangeStatic()
        {
            //a=6 ?
            //  a = 20;
            //ChangeNormal();
        }
    }
}
