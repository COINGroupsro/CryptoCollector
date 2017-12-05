using System;

namespace CoinGroup.CryptoCollector.Core.Model
{
    public class Trade
    {
        public Trade(
            ExchangeCurrencyPair currencyPair,
            decimal price,
            decimal quantity,
            decimal total,
            DateTime timestamp,
            OrderType type)
        {
            Key = currencyPair;
            Price = price;
            Quantity = quantity;
            Total = total;
            Timestamp = timestamp;
            Type = type;
        }

        public Trade(
            string exchange,
            string primaryCurrency,
            string secondaryCurrency,
            decimal price,
            decimal quantity,
            decimal total,
            DateTime timestamp,
            OrderType type)
            : this(
                new ExchangeCurrencyPair(exchange, primaryCurrency, secondaryCurrency),
                price,
                quantity,
                total,
                timestamp,
                type)
        {
        }

        public ExchangeCurrencyPair Key { get; }

        public decimal Price { get; }

        public decimal Quantity { get; }

        public decimal Total { get; }

        public DateTime Timestamp { get; }

        public OrderType Type { get; }

        public override string ToString()
        {
            return $"{nameof(Key)}: {Key}, {nameof(Price)}: {Price}, {nameof(Quantity)}: {Quantity}, {nameof(Total)}: {Total}, {nameof(Timestamp)}: {Timestamp}, {nameof(Type)}: {Type}";
        }
    }
}
