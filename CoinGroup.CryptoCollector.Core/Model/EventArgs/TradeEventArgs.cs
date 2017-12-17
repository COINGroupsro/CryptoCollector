using System;
using System.Collections.Generic;

namespace CoinGroup.CryptoCollector.Core.Model.EventArgs
{
    public class TradeEventArgs : System.EventArgs
    {
        public TradeEventArgs(DateTime timestamp, IEnumerable<Trade> trades)
        {
            Timestamp = timestamp;
            Trades = trades;
        }

        public DateTime Timestamp { get; }

        public IEnumerable<Trade> Trades { get; }

        public override string ToString()
        {
            return $"{nameof(Timestamp)}: {Timestamp}, {nameof(Trades)}: {Trades}";
        }
    }
}
