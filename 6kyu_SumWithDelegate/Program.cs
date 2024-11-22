﻿//Создайте обобщенный делегат Summator. 
//Программа должна выводить: 
//5 + 13 = 18
//"Отличный" + "курс" = Отличный курс
//'1' + '2' = c

using System;

namespace CSharpEssentials
{
    // Создайте обобщенный делегат Summator
    public delegate T Summator<T>(T a, T b);
    class Program
    {
        static int SumInt(int a, int b)
        {
            return a + b;
        }
        static string SumStr(string s1, string s2)
        {
            return s1 + " " + s2;
        }
        static char SumCh(char a, char b)
        {
            return (char)(a + b);
        }

        static void Main()
        {
            Summator<int> del1 = SumInt;
            Console.WriteLine("5 + 13 = " + del1(5, 13));

            Summator<string> del2 = SumStr;
            Console.WriteLine("\"Отличный\" + \"курс\" = " + del2("Отличный", "курс"));

            Summator<char> del3 = SumCh;
            Console.WriteLine("'1' + '2' = " + del3('1', '2'));
        }
    }
}