using System;

namespace FibonacciNamespace
{
    public class FibonacciLoopImpl : Fibonacci
    {
        public int Calc(int index)
        {
            // Validate index
            ValidateIntBetween(index, 0, 46, "Index");

            // Calculate Fibonacci number
            if (index == 0)
            {
                return 0;
            }

            if (index == 1)
            {
                return 1;
            }

            int prev = 0;
            int current = 1;
            for (int i = 2; i <= index; i++)
            {
                int next = prev + current;
                prev = current;
                current = next;
            }

            return current; 
        }

        public static void ValidateIntBetween(int value, int min, int max, string param)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException($"{param} must be between {min} and {max}!");
            }
        }
    }
}
