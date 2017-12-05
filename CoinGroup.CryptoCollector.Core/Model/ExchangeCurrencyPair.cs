using System;
using System.Collections.Generic;

namespace CoinGroup.CryptoCollector.Core.Model
{
    public class ExchangeCurrencyPair
    {
        public ExchangeCurrencyPair(string exchange, string primaryCurrency, string secondaryCurrency)
        {
            this.Exchange = exchange ?? throw new ArgumentNullException(nameof(exchange));
            this.PrimaryCurrency = primaryCurrency ?? throw new ArgumentNullException(nameof(primaryCurrency));
            this.SecondaryCurrency = secondaryCurrency ?? throw new ArgumentNullException(nameof(secondaryCurrency));
        }

        public static IEqualityComparer<ExchangeCurrencyPair> Comparer { get; } = new ExchangeCurrencyPairEqualityComparer();

        public string Exchange { get; }

        public string PrimaryCurrency { get; }

        public string SecondaryCurrency { get; }

        public override string ToString()
        {
            return $"{nameof(this.Exchange)}: {this.Exchange}, Pair: {PrimaryCurrency}-{SecondaryCurrency}";
        }

        private sealed class ExchangeCurrencyPairEqualityComparer : IEqualityComparer<ExchangeCurrencyPair>
        {
            public bool Equals(ExchangeCurrencyPair x, ExchangeCurrencyPair y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return string.Equals(x.Exchange, y.Exchange) && string.Equals(x.PrimaryCurrency, y.PrimaryCurrency) && string.Equals(x.SecondaryCurrency, y.SecondaryCurrency);
            }

            public int GetHashCode(ExchangeCurrencyPair obj)
            {
                unchecked
                {
                    var hashCode = obj.Exchange != null ? obj.Exchange.GetHashCode() : 0;
                    hashCode = (hashCode * 397) ^ (obj.PrimaryCurrency != null ? obj.PrimaryCurrency.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.SecondaryCurrency != null ? obj.SecondaryCurrency.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }
    }
}
