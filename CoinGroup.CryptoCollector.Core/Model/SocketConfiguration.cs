using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGroup.CryptoCollector.Core.Model
{
    public class SocketConfiguration
    {
        public SocketConfiguration(int receiveBufferSize, int sendBufferSize, TimeSpan timeout)
        {
            ReceiveBufferSize = receiveBufferSize;
            SendBufferSize = sendBufferSize;
            Timeout = timeout;
        }

        public int ReceiveBufferSize { get; }

        public int SendBufferSize { get; }

        public TimeSpan Timeout { get; }

        public static SocketConfiguration CreateDefault()
        {
            return new SocketConfiguration(1024, 1024, TimeSpan.FromSeconds(15));
        }
    }
}
