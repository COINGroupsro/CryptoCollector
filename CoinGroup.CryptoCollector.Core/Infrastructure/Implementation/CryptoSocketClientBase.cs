using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

using CoinGroup.CryptoCollector.Core.Model;
using CoinGroup.CryptoCollector.Core.Model.EventArgs;

using NLog;

namespace CoinGroup.CryptoCollector.Core.Infrastructure.Implementation
{
    public abstract class CryptoSocketClientBase : ICryptoSocketClient
    {
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        private Task<bool> _trueCompletedTask;

        private ClientWebSocket _socket = new ClientWebSocket();

        public event EventHandler<TradeEventArgs> OnTradesReceived;

        public Task SubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            _logger.Debug($"Subscribing to {primaryCurrency}-{secondaryCurrency}");
            throw new NotImplementedException();
        }

        public Task UnsubscribeAsync(string primaryCurrency, string secondaryCurrency)
        {
            _logger.Debug($"Unsubscribing from {primaryCurrency}-{secondaryCurrency}");
            throw new NotImplementedException();
        }

        protected virtual Task<bool> IsAuthenticated() =>
            _trueCompletedTask ?? (_trueCompletedTask = Task.FromResult(true));

        protected virtual Task Authenticate() => Task.CompletedTask;

        protected abstract IEnumerable<Trade> ParseTrades(string message);

        private void RaiseOnTradesReceived(IEnumerable<Trade> trades)
        {
            OnTradesReceived?.Invoke(this, new TradeEventArgs(new DateTime(Stopwatch.GetTimestamp()), trades));
        }
    }
}
