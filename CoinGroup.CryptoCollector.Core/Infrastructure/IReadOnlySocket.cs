using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CoinGroup.CryptoCollector.Core.Infrastructure
{
    public interface IReadOnlySocket
    {
        WebSocketState State { get; }

        Task ConnectAsync();
    }
}
