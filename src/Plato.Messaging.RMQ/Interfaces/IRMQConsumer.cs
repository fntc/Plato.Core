// Plato.Core
// Copyright (c) 2020 ReflectSoftware Inc.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Plato.Messaging.Enums;
using Plato.Messaging.Interfaces;

namespace Plato.Messaging.RMQ.Interfaces
{
    public interface IRMQConsumer : IRMQQueue, IMessageReceiverSender
    {
        ConsumerMode Mode { get; set; }
        void ClearCacheBuffer();
    }
}
