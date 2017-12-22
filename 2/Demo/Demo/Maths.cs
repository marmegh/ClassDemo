using System;

namespace Demo
{
    public class Maths
    {
        private int val1 { get; set; }
        private int val2 { get; set; }

        public Maths (int first, int second)
        {
            val1 = first;
            val2 = second;
        }

        public int sum(int first, int second)
        {
            return first + second;
        }
        public int suMem()
        {
            return val1 + val2;
        }
    }
}
