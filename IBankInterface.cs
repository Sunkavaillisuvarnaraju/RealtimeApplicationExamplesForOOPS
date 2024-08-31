using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationUsingInterface
{
    public  interface IBankInterface
    {
         void CheckBalance();
         void AmoutWithdraw();
         void AmoutDeposite();
         void ValidateCard();
         void BankTransfer();

    }
}
