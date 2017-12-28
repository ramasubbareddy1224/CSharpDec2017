using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public interface ITransaction
    {
        int AccountID { get; set; }
        void ShowTransaction();
        double GetAmount();

    }

    public interface IDisplay
    {
        void DisplayMessage();
        double GetAmount();
    }
   
}
