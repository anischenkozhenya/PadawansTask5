﻿using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            bool realtrue = false;
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length < 1)
                throw new ArgumentException();
            for (int i = 0, j = source.Length - 1; j > 0 && i < source.Length; i++, j--)
            {
                if (source[i] == source[j])
                {
                    realtrue = true;
                }
                else
                {
                    realtrue = false;
                    break;
                }
            }
            if (realtrue == false)
            {
                return "No";
            }
            else
            {
                return "Yes";
            }
        }
    }
}

