using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loanAmount, interest, emi;
                float salary=26000;

            LoanCalculation ViejaPuta = new LoanCalculation();
            ViejaPuta.ApplyForLoan(salary,out loanAmount,out interest,"Pasaporte","curp");
            ViejaPuta.SalaryDeduction(ref salary,2,5,interest,loanAmount,out emi);
        }
    }
}
