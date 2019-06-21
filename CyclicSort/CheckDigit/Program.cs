using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrNumber = "543215432154321";
            int result = CheckDigit(StrNumber);
            Console.WriteLine("The Check Degit for  " +StrNumber + "  is  :   "  + result);
            Console.ReadLine();
        }
         public static int CheckDigit(string StringNumber )
        {
            int ResultNumber = StringNumber.Select((c, i) => (c - '0') * ("357"[i % 3] - '0')).Sum();
            string StringSumValue = ResultNumber.ToString();
            var FinalValue = StringSumValue.Select(c => c - '0').ToArray();
            int ResultofCheckNumber = 0;
            for (int i = 0; i < FinalValue.Length; i++)
            {
                ResultofCheckNumber += FinalValue[i];
            }

            return ResultofCheckNumber;
        }

    }
}
