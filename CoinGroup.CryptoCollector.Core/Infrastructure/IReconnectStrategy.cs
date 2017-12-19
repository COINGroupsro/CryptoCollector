﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoinGroup.CryptoCollector.Core.Infrastructure
{
    public interface IReconnectStrategy
    {
        Task AttemptToReconnectAsync(IReadOnlySocket socket);
    }
}
