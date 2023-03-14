using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Banorque
    {
        public int loanAmount;
        public int interest;
        public bool ApplyForLoan(float salary,out int loanAmount,out int interest, params string[]doc ){
            loanAmount = this.loanAmount;
            interest = this.interest;
            foreach(var item in doc)
            {
       
                if (item.ToLower().Equals("pasaporte")&& doc.Length>=2)
                {
                    if(salary > 0 && salary<12000) {
                        Console.WriteLine("Loan Amount: 25000, Interest=4%");
                    }else if(salary <= 50000 && salary>=12000)
                    {
                        Console.WriteLine("Loan Amount: 50000, Interest=6%");
                    }
                    else if (salary >= 50000)
                    {
                        Console.WriteLine("Loan Amount: 100000, Interest=8%");
                    }
                    
                    return true;
                }
            }
            return false;
        }
        public void Emi_Discount()
        {

        }
    }
}
