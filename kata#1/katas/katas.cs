﻿using System;

namespace katas
{
    public class Katas
    {
        // return the remainder of the division a / b
        public int modulo(int a, int b) => a % b;
        // return the square root of the given number
        public double squareRoot(double a) => Math.Sqrt(a);
        // return the length of the passed string
        public int getLength(string str) => str.Length;
        // return the first and last names with a space between them
        public string putNamesTogether(string firstname, string lastname) => $"{firstname} {lastname}";
        // return the passed string with its first letter capitalised
        public string capitaliseString(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
