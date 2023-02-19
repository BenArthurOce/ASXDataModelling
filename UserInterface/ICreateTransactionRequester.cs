using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;

namespace UserInterface
{

    //What this do?
    //Whoever impliments this contract, will have one method called "TransactionComplete", that will return nothing but takes in a model
    // How helpful? If I take the interface, go to a form and say "you have to pass in the interface"
    // We need to know this outside different form scopes. "Loose Coupling"
    public interface ICreateTransactionRequester
    {
        void CreateTransactionComplete(TradingTransactionModel model);
    }
}
