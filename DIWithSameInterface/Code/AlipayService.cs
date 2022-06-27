using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWithSameInterface.Code
{
    public class AlipayService : IWalletService
    {
        public EnumWalletType WalletType { get; } = EnumWalletType.Alipay;

        public void Debit(decimal amount)
        {
            // 從支付寶扣錢

            System.Diagnostics.Debug.WriteLine($"Debit from {WalletType}");
        }
    }
}
