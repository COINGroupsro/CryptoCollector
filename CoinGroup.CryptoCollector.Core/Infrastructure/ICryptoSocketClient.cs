using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoinGroup.CryptoCollector.Core.Infrastructure
{
    public interface ICryptoSocketClient
    {
        Task SubscribeAsync(string primaryCurrency, string secondaryCurrency);

        Task UnsubscribeAsync(string primaryCurrency, string secondaryCurrency);
    }
}
