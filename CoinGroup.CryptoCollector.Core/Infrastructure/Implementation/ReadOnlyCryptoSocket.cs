using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CoinGroup.CryptoCollector.Core.Model;

using NLog;

namespace CoinGroup.CryptoCollector.Core.Infrastructure.Implementation
{
    public class ReadOnlyCryptoSocket : IReadOnlySocket
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        private readonly ClientWebSocket _socket = new ClientWebSocket();

        private readonly Uri _uri;

        private CancellationToken _cancellationToken;

        private readonly SocketConfiguration _configuration;

        public ReadOnlyCryptoSocket(Uri uri)
        {
            _uri = uri;
            _configuration = SocketConfiguration.CreateDefault();
        }

        public ReadOnlyCryptoSocket(Uri uri, SocketConfiguration configuration)
            : this(uri, new CancellationTokenSource(configuration.Timeout).Token, configuration)
        {
        }

        public ReadOnlyCryptoSocket(Uri uri, CancellationToken cancellationToken, SocketConfiguration configuration)
        {
            _uri = uri;
            _cancellationToken = cancellationToken;
            _configuration = configuration;
        }

        public WebSocketState State => _socket.State;

        public async Task ConnectAsync()
        {
            if (State == WebSocketState.Open || State == WebSocketState.Connecting)
            {
                Logger.Debug("Socket is already connected/connecting not connecting again.");
                return;
            }

            if (State == WebSocketState.Aborted)
            {
                Logger.Warn("Socket is aborted it needs to reinitialized first.");
                return;
            }

            Logger.Debug($"Connecting to {_uri}");
            await _socket.ConnectAsync(_uri, )
        }
    }
}
