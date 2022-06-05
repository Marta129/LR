using System;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            string[] a = new string[n];
            int[] vector = new int[n];
            int[] min = new int[n];
            int[] max = new int[n];
            a = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
            {
                vector[i] = int.Parse(a[i]);
            }
            max[0] = vector[0];
            for(int i=1;i<n;++i)
            {
                if(vector[i]<max[i-1])
                {
                    max[i] = max[i - 1];
                }
                else
                {
                    max[i] = vector[i];
                }
            }
            min[n - 1] = vector[n - 1];
            for(int i=n-2;i>=0;--i)
            {
                if(vector[i]>min[i+1])
                {
                    min[i] = min[i + 1];
                }
                else
                {
                    min[i] = vector[i];
                }
            }
            for(int i=1;i<n-1;++i)
            {
                if(max[i-1]<=vector[i] && vector[i]<=min[i+1])
                {
                    contor++;
                }
            }
            Console.WriteLine(contor);

        }
    }
}
