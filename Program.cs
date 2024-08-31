using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationUsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction from SBI");
             IBankInterface bankObject =   BankFactory.GetBankObject("SBI");
            bankObject.ValidateCard();
            bankObject.CheckBalance();
            bankObject.AmoutWithdraw();
            bankObject.AmoutDeposite();
            bankObject.BankTransfer();
            Console.WriteLine();    
            Console.WriteLine("Transaction from AXIS");
            IBankInterface bankObject1 = BankFactory.GetBankObject("Axis");
            bankObject1.ValidateCard();
            bankObject1.CheckBalance();
            bankObject1.AmoutWithdraw();
            bankObject1.AmoutDeposite();
            bankObject1.BankTransfer();

            Console.ReadLine();
        }
    }
}
