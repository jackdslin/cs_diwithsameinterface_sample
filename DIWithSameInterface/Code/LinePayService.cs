using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWithSameInterface.Code
{
    public class LinePayService : IWalletService
    {
        public EnumWalletType WalletType { get; } = EnumWalletType.LinePay;

        public void Debit(decimal amount)
        {
            // 從 Line Pay 扣錢

            System.Diagnostics.Debug.WriteLine($"Debit from {WalletType}");
        }
    }
}
