using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LoanCalculation
    {
        public LoanCalculation()
        {
        }

        public bool ApplyForLoan(float salary, out int loanAmount, out int interest, params string[] doc)
        {

            foreach (var item in doc)
            {

                if (item.ToLower().Equals("pasaporte") && doc.Length >= 2)
                {
                    if (salary > 0 && salary < 12000)
                    {
                        Console.WriteLine("Loan Amount: 25000, Interest=4%");
                        loanAmount = 25000;
                        interest = 4;
                        return true;
                    }
                    else if (salary <= 50000 && salary >= 12000)
                    {
                        Console.WriteLine("Loan Amount: 50000, Interest=6%");
                        loanAmount = 50000;
                        interest = 6;
                        return true;
                    }
                    else if (salary >= 50000)
                    {
                        loanAmount = 100000;
                        interest = 8;
                        Console.WriteLine("Loan Amount: 100000, Interest=8%");
                        return true;
                    }


                }

            }
            loanAmount = 0;
            interest = 0;
            return false;

        }
        public void Emi_Discount(int loanAmount, int RelativeMarking, int tenure, int interest, out int emi)
        {
            emi = (loanAmount + (loanAmount * interest / 100)) / tenure;
            Console.WriteLine("Tu emi es: " + emi);
            if (RelativeMarking == 1)
            {
                emi =(emi * 10 / 100);
            }
            else if (RelativeMarking == 2)
            {
                emi =(emi * 8 / 100);
            }
            else if (RelativeMarking == 3)
            {
                emi =(emi * 6 / 100);
            }
            else if (RelativeMarking > 3)
            {
                emi =(emi * 4 / 100);
            }
        }
        public void SalaryDeduction(ref float salary, int relativeMarking, int tenure, int interest, int LoanAmount, out int emi)
        {
            
            Emi_Discount(LoanAmount,relativeMarking,tenure,interest,out emi);
            salary = salary - emi;
            Console.WriteLine("Tu salario es: " + salary);

        }
    }
}
