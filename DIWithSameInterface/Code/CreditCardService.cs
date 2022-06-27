using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWithSameInterface.Code
{
    public class CreditCardService : IWalletService
    {
        public EnumWalletType WalletType { get; } = EnumWalletType.CreditCard;

        public void Debit(decimal amount)
        {
            // 從信用卡扣錢

            System.Diagnostics.Debug.WriteLine($"Debit from {WalletType}");
        }
    }
}
