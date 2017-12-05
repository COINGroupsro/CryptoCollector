using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

using CoinGroup.CryptoCollector.Bitfinex.Model;
using CoinGroup.CryptoCollector.Core.Infrastructure;
using CoinGroup.CryptoCollector.Core.Model;

namespace CoinGroup.CryptoCollector.Bitfinex
{
    public class BitfinexSocketClient : ICryptoSocketClient
    {
        private readonly BitfinexSocketConfiguration _configuration;

        private ClientWebSocket _socket;
        
        public BitfinexSocketClient(BitfinexSocketConfiguration configuration)
        {
            _configuration = configuration;
        }

        #region ICryptoSocketClient implementation

        public Task SubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            return SubscribeAsync(CreateCurrencyPair(primaryCurrency, secondaryCurrency));
        }

        public Task UnsubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Task SubscribeAsync(ExchangeCurrencyPair currencyPair)
        {
        }

        private ExchangeCurrencyPair CreateCurrencyPair(string primaryCurrency, string secondaryCurrency)
        {
            return new ExchangeCurrencyPair(_configuration.ExchangeKey, primaryCurrency, secondaryCurrency);
        }
    }
}
