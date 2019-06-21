using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicSort
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            //D E F G H I J A B C
            //GDBACFJEHI
            int K =7;
            char [] output = cyclicSort(input, K);
            foreach (char day in input)
                Console.Write(day + " ");
            Console.ReadLine();
        }

        public static char[] cyclicSort(char[] input, int ordering)
        {
            List<char> my_list = new List<char> ();
            foreach (var item in input)
            {
                my_list.Add(item);
            }
            int counter = 1;
            do
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (counter == ordering)
                    {
                       // Console.WriteLine(my_list[i]);
                        char charToRemove = my_list[i];
                        my_list.Remove(charToRemove);
                        counter = 1;
                       // break;
                
                    }
                    counter++;

                }

            }
            while (my_list.Count > 0);
            input = new char[input.Length - my_list.Count];
            return input;

        }


          


        }
}
