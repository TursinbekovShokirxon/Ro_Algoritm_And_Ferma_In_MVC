using Crypt.Interfaces;
using Crypt.Models;

namespace Crypt.Services
{
    public class GCD : IGCD
    {
        public Ferma FermaAlgoritm(int N)
        {

            int s = (int)Math.Sqrt(N);
            int k = 1;
            double y = Math.Pow((s + k), 2) - N;

            while ((Math.Sqrt(y) - (int)Math.Sqrt(y)) != 0)
            {
                Console.WriteLine("1 - " + y + "\n");// Вывод каждого Y который выводится 
                k++;
                y = Math.Pow(s + k, 2) - N;
            }
            int a = s + k + (int)Math.Sqrt(y);
            int b = s + k - (int)Math.Sqrt(y);
            return new Ferma { FirstNumber = a, SecondNumber = b };
        }


        public Pollard PollardAlgoritm(int N)
        {
            int x = 2, y = 2;
            int NOD = 0;

            while (true)
            {
                int FX = ((int)Math.Pow(x, 2) + 1) % N;
                int DoY = ((int)Math.Pow(y, 2) + 1) % N;
                int YX = ((int)Math.Pow(DoY, 2) + 1) % N;
                x = FX; y = YX;
                int b = YX - FX;
                NOD = FindNOD(b, N);

                // Log or return the results as needed
                Console.WriteLine($"Xi : {FX} Yi : {YX} NOD({Math.Abs(FX - YX)},{N}) : {NOD}");

                if (NOD != N && NOD != 1 && NOD != 0) break;
            }
            if (N < 0) N *= -1;
            if (NOD < 0) NOD *= -1;
            return new Pollard { FirstNumber = N / NOD, SecondNumber = NOD };
        }

        private int FindNOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}
