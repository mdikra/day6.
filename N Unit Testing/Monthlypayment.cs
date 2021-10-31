using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTesting
{
    class Monthlypayment
    {
         static void Main(string[] args)
        {

            var testDefault = new MonthlyPayment();
            testDefault.DisplayObjectState();
            Console.WriteLine("\n");

            var real = new MonthlyPayment(10000, 10, 12);
            real.DisplayObjectState();

            Console.WriteLine("\n");
            Console.WriteLine("Monthy Payment Amount: {0}", real.MonthlyPaymentAmount());
            Console.WriteLine("\n");
            Console.WriteLine("Amount Paid Back: {0}", real.AmountPaidBack());
            Console.WriteLine("\n");
            Console.WriteLine("Interest Paid: {0}", real.InterestPaid());

            Console.WriteLine("\n");

        }
    }
}
