using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class BaseTransaction
    {

    }
    public class Base1Transaction
    {

    }

    public class Transactions : BaseTransaction, IDisplay, ITransaction
    {
        public int AccountID { get; set; }

        public void ShowTransaction()
        {
            Console.WriteLine("Transaction completed successfully");
        }
        double ITransaction.GetAmount()
        {
            return 100;
        }
        double IDisplay.GetAmount()
        {
            return 200;
        }
        public void DisplayMessage()
        {
            Console.WriteLine("This is Display from IDisplay interface");
        }

    }
}
