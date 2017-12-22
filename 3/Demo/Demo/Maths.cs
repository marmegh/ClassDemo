using System;

namespace Demo
{
    //note class must be public in order to utilize for a test
    public class Maths
    {
        private int val1 { get; set; }
        private int val2 { get; set; }

        //note constructor must be public in order to utilize for a test
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
