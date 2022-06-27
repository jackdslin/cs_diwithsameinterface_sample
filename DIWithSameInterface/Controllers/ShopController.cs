using DIWithSameInterface.Code;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWithSameInterface.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IEnumerable<IWalletService> _walletServices;


        /// <summary>
        /// 建構子
        /// </summary>
        public ShopController(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            this._walletServices = this._serviceProvider.GetRequiredService<IEnumerable<IWalletService>>();
        }

        //[Consumes("application/json")]
        public IActionResult CheckOut(EnumWalletType walletType, decimal amount)
        {
            var walletService = _walletServices.Single(x => x.WalletType == walletType);
            walletService.Debit(amount);
            return Ok();
        }


    }
}
