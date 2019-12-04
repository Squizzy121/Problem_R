using System;

namespace R
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int n = 0;
            int l = x.Length; 
            for (int q = 0;q <= l-1; q++)
            {
                if (x[q]=='6'||x[q]=='9'||x[q]=='0')
                {
                    ++n;
                }
                if (x[q]=='8')
                {
                    n += 2;
                }
            }
            Console.WriteLine(n);
        }
    }
}
