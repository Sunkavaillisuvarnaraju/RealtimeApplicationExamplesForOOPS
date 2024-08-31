using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationUsingInterface
{
    public  class AXIS :IBankInterface
    {
        public void ValidateCard()
        {
            Console.WriteLine("Validating the Card pls wait");
        }
        public void CheckBalance()
        {
            Console.WriteLine("Checking the balance pls wait");
        }
        public void AmoutWithdraw()
        {
            Console.WriteLine("Withdrawing  the Money pls wait");
        }
        public void AmoutDeposite()
        {
            Console.WriteLine("Depositing the Money pls wait");
        }
        public void BankTransfer()
        {
            Console.WriteLine("Transfering the Money pls wait");
        }
    }
}
