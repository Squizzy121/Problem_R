using System;

namespace zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        { //2.	Відомо, що у рядку є хоча б один символ " * " (зірочка).
            //Знайти номер останнього входження "*"у рядок і перерахувати кількість усіх входжень "*" у рядок (величина п).
            //Додати символ "*" на початок рядка, повторити його п разів.
            string str = Console.ReadLine();
            string str2 = "*";
            int n = 0;
            int last=0;
            int l = str.Length - 1;
            for (int q=0;q<=l;++q)
            {
                if (str[q]=='*')
                {
                    n+=1;
                    str=str.Remove(q, 1);
                    l--;
                    q--;
                    last = q + n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Кількість * (зірочок) у рядку: {0}",n);
            Console.WriteLine("Індекс останньої * (зірочки) у рядку: {0}",last);
            
            for (int q=1;q<=n;q++)
            {
                str = String.Concat(str2, str);
            }
            Console.WriteLine();
            Console.WriteLine(str);
        }
    }
}
