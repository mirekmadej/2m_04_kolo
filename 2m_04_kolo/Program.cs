namespace _2m_04_kolo
{
    class Kolo
    {
        private double promien;

        public Kolo(double R=0) 
        {
            promien = R;
        }

        ~Kolo()
        {
            Console.WriteLine("a ja jestem destruktorem klasy kolo");
        }

        public void wczytajDane()
        {
            Console.Write("Podaj dł promienia: ");
            promien = double.Parse(Console.ReadLine());
        }
        public void wypiszDane()
        {
            Console.WriteLine($"koło o promieniu {promien}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kolo kolo = new Kolo(5);
         //   kolo.wczytajDane();
            kolo.wypiszDane();
            Kolo k1 = new Kolo();
            kolo.wczytajDane();
            kolo.wypiszDane();


        }
    }
}