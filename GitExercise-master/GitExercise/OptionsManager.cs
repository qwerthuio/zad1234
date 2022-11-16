﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "pow - Power",
            "log - Logarithm",
            "fact - sum of 2 factorials "
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        internal static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
        }

        internal static void Log(double a, double b)
        {
            Console.WriteLine($"log of {a} with base {b} = {Math.Log(a - b)}");
        }

        internal static void Factoria(double a, double b)
        {
            long factA = CalculateFact((int)a);
            long factB = CalculateFact((int)b);
            Console.WriteLine($"{a}! + {b}! = {(int)a}! + {(int)b}! = {factA + factB}");

        }
        private static long CalculateFact(int a)
        {
            long result = a;
            for (int i = a - 1; i >= 1; i--)
            {
                result = result *i;
            }
            return result;
        }
    }
}
