using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            bool realtrue = false;
            try
            {
                if (source == null)
                {
                    throw new ArgumentNullException();
                }
                if (source.Length == 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentNullException ex)
            {

            }
            catch (ArgumentException ex)
            {

            }
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

