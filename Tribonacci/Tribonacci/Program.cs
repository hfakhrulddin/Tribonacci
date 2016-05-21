using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] signature;
            signature = Convert.ToCharArray(Console.ReadLine());

            Xbonacci.Tribonacci(signature, n);
        }
    }
}
public class Xbonacci
{
    public static double[] Tribonacci(double[] signature, int n)
    {

        for (int i = 0; i < (n - 3); i++)
        {

            signature[i + 3] = signature[i] + signature[i + 1] + signature[i + 2];

        }
        return signature;
    }
}