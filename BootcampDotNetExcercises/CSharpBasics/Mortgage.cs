using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Mortgage
    {
        public int loanNumber;
        public double loanAmount;
        public double interestRate;
        public int numberOfMonths;
        public LoanType loanType;

        public Mortgage(int number)
        {
            loanNumber = number;
        }

        public Mortgage(int number, double amount, double rate, LoanType type, int months)
        {
            loanAmount = amount;
            interestRate = rate;
            loanType = type;
            loanNumber = number;
            numberOfMonths = months;
        }


        public double CalculateTotalCost()
        {
            return loanAmount + (loanAmount * interestRate);
        }

        public double CalculatePayment()
        {
            return (loanAmount + (loanAmount * interestRate))/numberOfMonths;
        }

        public string ToString()
        {
            return $"{loanNumber} - {loanAmount} for {numberOfMonths} months";
        }
    }
}
