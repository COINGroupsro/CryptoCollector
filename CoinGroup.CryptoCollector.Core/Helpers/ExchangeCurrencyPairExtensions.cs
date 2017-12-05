using System;
using System.Collections.Generic;
using System.Text;

using CoinGroup.CryptoCollector.Core.Model;

namespace CoinGroup.CryptoCollector.Core.Helpers
{
    internal static class ExchangeCurrencyPairExtensions
    {
        internal static string CreateBitfinexPair(this ExchangeCurrencyPair currencyPair)
        {
            return $"t{currencyPair.PrimaryCurrency.ToUpper()}{currencyPair.SecondaryCurrency.ToUpper()}";
        }
    }
}
