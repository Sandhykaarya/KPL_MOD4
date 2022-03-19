using System;

namespace modul4_1302204002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> pjh = new List<float>();
            Penjumlahan pj = new Penjumlahan();

            pj.JumlahTigaAngka<float>(13, 02, 20);
        }
    }

    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T satu, T dua, T tiga)
        {
            dynamic X = satu;
            dynamic Y = dua;
            dynamic Z = tiga;
            dynamic A = X + Y + Z;
            Console.WriteLine(A);
        }
    }
}