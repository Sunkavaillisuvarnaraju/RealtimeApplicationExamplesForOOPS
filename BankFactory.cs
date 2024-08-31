using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationUsingInterface
{
    public  class BankFactory
    {
        public static IBankInterface GetBankObject(string bankName)
        {
            IBankInterface bank = null;
            if(bankName == "SBI")
            {
                bank = new SBI();
            }
            else if(bankName =="Axis")
            {
                bank = new AXIS();
            }
            return bank;
        }
    }
}
