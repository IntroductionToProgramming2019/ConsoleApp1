/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : tax band calculator CA attempt
 * 
 * ############################# */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int a = 0;
        static int b = 0;
        static int c = 0;
        static int d = 0;
        static int e = 0;
        static int f = 0;
        static int g = 0;
        static int[] numberInBandA = new int[100];
        static int[] numberInBandB = new int[100];
        static int[] numberInBandC = new int[100];
        static int[] numberInBandD = new int[100];
        static int[] numberInBandE = new int[100];
        static int[] numberInBandF = new int[100];
        static int[] numberInBandG = new int[100];
        const double RATE_A = 0.18;
        const double RATE_B = 0.20;
        const double RATE_C = 0.21;
        const double RATE_D = 0.23;
        const double RATE_E = 0.30;
        const double RATE_F = 0.33;
        const double RATE_G = 0.50;
        static double AllTax;
        static double first = 0;
        static double second = 0;
        static double third = 0;
        static double fourth = 0;
        static double fifth = 0;
        static double sixth = 0;
        static double seventh = 0;




        static void Main(string[] args)
        {
            int input = 0;
            while (input != -999)
            {
                Console.WriteLine("Enter property value (-999 to end): ");
                input = int.Parse(Console.ReadLine());
                FindBand(input);
                taxA();
                taxB();
                taxC();
                taxD();
                taxE();
                taxF();
                taxG();
            }
            Output();
        }
        static void FindBand(int input)
        {
            if (input > 0 && input <= 100000)
            {
                numberInBandA[a] = input;
                a++;
            }
            else if (input > 100000 && input <= 150000)
            {
                numberInBandB[b] = input;
                b++;
            }
            else if (input > 150000 && input <= 200000)
            {
                numberInBandC[c] = input;
                c++;
            }
            else if (input > 200000 && input <= 250000)
            {
                numberInBandD[d] = input;
                d++;
            }
            else if (input > 250000 && input <= 300000)
            {
                numberInBandE[e] = input;
                e++;
            }
            else if (input > 300000 && input <= 500000)
            {
                numberInBandF[f] = input;
                f++;
            }
            else if (input > 500000)
            {
                numberInBandG[g] = input;
                g++;
            }
        }
        static void taxA()
        {
            for (int i = 0; i < a; i++)
            {
                first = first + (numberInBandA[i] * RATE_A);
                AllTax = AllTax + first;
            }
        }
        static void taxB()
        {
            for (int i = 0; i < b; i++)
            {
                second = second + (RATE_B * numberInBandB[i]);
                AllTax = AllTax + second;
            }
        }
        static void taxC()
        {
            for (int i = 0; i < c; i++)
            {
                third = third + (RATE_C * numberInBandC[i]);
                AllTax = AllTax + third;

            }
        }
        static void taxD()
        {
            for (int i = 0; i < d; i++)
            {
                fourth = fourth + (RATE_D * numberInBandD[i]);
                AllTax = AllTax + fourth;

            }
        }
        static void taxE()
        {
            for (int i = 0; i < e; i++)
            {
                fifth = fifth + (RATE_E * numberInBandE[i]);
                AllTax = AllTax + fifth;

            }
        }
        static void taxF()
        {
            for (int i = 0; i < f; i++)
            {
                sixth = sixth + (RATE_F * numberInBandF[i]);
                AllTax = AllTax + sixth;

            }
        }
        static void taxG()
        {
            for (int i = 0; i < g; i++)
            {
                seventh = seventh + (RATE_G * numberInBandG[i]);
                AllTax = AllTax + seventh;

            }
        }
        static void Output()
        {
            Console.WriteLine("Range          Num of Properties        Total Payable");
            Console.WriteLine("0-100,000                {0}         {1}", a, first);
            Console.WriteLine("101,000 - 150,000        {0}         {1}", b, second);
            Console.WriteLine("150,001 - 200,000        {0}         {1}", c, third);
            Console.WriteLine("200,001 - 250,000        {0}         {1}", d, fourth);
            Console.WriteLine("250,001 - 300,000        {0}         {1}", e, fifth);
            Console.WriteLine("300,001 - 500,000        {0}         {1}", f, sixth);
            Console.WriteLine("500,000+                 {0}         {1}", g, seventh);
            int totalProperties = a + b + c + d + e + f + g;
            Console.WriteLine("Totals                   {0}         {1}", totalProperties, AllTax);

        }

    }
}
