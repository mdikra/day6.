using System;

namespace NunitTesting
{
    internal class MonthlyPayment
    {
        private int v1;
        private int v2;
        private int v3;

        public MonthlyPayment()
        {
        }

        public MonthlyPayment(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal void DisplayObjectState()
        {
            throw new NotImplementedException();
        }

        internal int MonthlyPaymentAmount()
        {
            throw new NotImplementedException();
        }

        internal int AmountPaidBack()
        {
            throw new NotImplementedException();
        }

        internal int InterestPaid()
        {
            throw new NotImplementedException();
        }
    }
}