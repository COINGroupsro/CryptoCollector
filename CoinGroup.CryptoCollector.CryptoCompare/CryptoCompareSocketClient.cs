using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using CoinGroup.CryptoCollector.Core.Infrastructure;
using CoinGroup.CryptoCollector.CryptoCompare.Model;

namespace CoinGroup.CryptoCollector.CryptoCompare
{
    public class CryptoCompareSocketClient : ICryptoSocketClient
    {
        private readonly CryptoCompareSocketConfiguration _configuration;

        public CryptoCompareSocketClient(CryptoCompareSocketConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            throw new NotImplementedException();
        }

        public Task UnsubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            throw new NotImplementedException();
        }
    }
}
