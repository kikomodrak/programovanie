namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strom strom1 = new Strom();


            double r;
            double h;
            double v = 0;
            double c = 0;


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Zadaj radius:");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadaj vysku:");
                h = double.Parse(Console.ReadLine());
                v = Math.PI * (r * r) * h / 3;
                c = v + c;
                Console.WriteLine("objem je:" + v);

            }
            Console.WriteLine("celkovy objem: " + c);
            Console.ReadLine();

        }

        class Strom : Organizmus
        {
            public Strom() { }
            ~Strom() { Console.WriteLine("destructor"); }
            public virtual double Volume
            {
                get { return 1.0 * Math.PI * (r * r) * h / 3; }
            }
            public virtual void Rastie()
            {

            }

            public double r;
            public double h;
        }

        class listnaty : Strom
        {
            public listnaty() { }
            ~listnaty() { }


        }

        class ihlicnaty : Strom
        {
            public double Volume
            {
                get { return Math.PI * (r * r) * h; }
            }
            public double r;
            public double h;
        }

        class Baobab : listnaty
        {
            public Baobab() { }
            ~Baobab() { }

            public override double Volume
            {
                get { return Math.PI * (r * r) * h; }
            }
          public double r;
          public double h;
        }

      

    }
}
