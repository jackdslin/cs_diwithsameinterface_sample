using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWithSameInterface.Code
{
    public interface IWalletService
    {
        EnumWalletType WalletType { get; }

        void Debit(decimal amount);
    }
}
