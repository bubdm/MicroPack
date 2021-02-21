﻿using System;

namespace MicroPack.Domain
{
    public interface IDomainEvent<out TKey>: IDomainEvent
    {
        long AggregateVersion { get; }
        TKey AggregateId { get; }
        DateTime Timestamp { get; }
    }
    
    public interface IDomainEvent
    {

    }
}