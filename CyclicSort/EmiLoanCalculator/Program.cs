using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmiLoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
              var PaymentAmout = CalcualteMothlyInstallment();
              Console.WriteLine("Monthly Repayment amount for 500000 as Principle at the rate of 4.65 for 30 Years Payment is  : "+PaymentAmout);            

            int Months = CalcualateNumberOfMoths();
            Console.WriteLine("Total Number of months Required to pay back the Amount  : "+Months);
            Console.WriteLine("Number of Years Required to pay back the Amount  : " + Months/12);
            var PrincipleAmount = CalcualtePrincipleAmount();
            Console.WriteLine("Loan Amount can be borrowed for 30 Years with monthly payment of 2000 RM   : " + PrincipleAmount);

            Console.ReadLine();
        }

        private static int   CalcualteMothlyInstallment()
        {

            var LoanAmount = 500000;
            var AcutualLoanAmout = LoanAmount - (LoanAmount / 10);
            var InterestRate = 4.65;
            var NumberOfYears = 30;
            var rateOfInterest = InterestRate / 1200;
            var numberOfPayments = NumberOfYears * 12;

            var paymentAmount = (rateOfInterest * AcutualLoanAmout) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));
          

            return Convert.ToInt32(paymentAmount);
        }

        public static int CalcualateNumberOfMoths()

        {

            var LoanAmount = 500000;
            var AcutualLoanAmout = LoanAmount - (LoanAmount / 10);
            var InterestRate = 4.65;   
            var rateOfInterest = InterestRate / 1200;
            var paymentAmount = 2000;

            var NumberOfMoths = -(Math.Log(1 - (AcutualLoanAmout * rateOfInterest) / paymentAmount)) / Math.Log(1 + rateOfInterest);
            return Convert.ToInt32(NumberOfMoths);

        }
        public static double CalcualtePrincipleAmount()
        {
           
            var Diposit = 5000;
            var InterestRate = 4.65/100;
            var rateOfInterest = InterestRate / 12;
            var paymentAmount = 2000;
            var NumberOfYears = 30;
            var numberOfPayments = NumberOfYears * 12;
            var LoanAmount = Diposit * (Math.Pow(1 +rateOfInterest, numberOfPayments)) + ((paymentAmount * ( Math.Pow(1 + rateOfInterest, numberOfPayments) - 1))) / (rateOfInterest);
                  
            return Convert.ToDouble(LoanAmount);
        }





    }

}
