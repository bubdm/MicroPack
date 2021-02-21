﻿using System.Threading.Tasks;
using MicroPack.Domain;

namespace MicroPack.EventStore
{
    public interface IEventsRepository<TA, in TKey>
        where TA : class, IAggregateRoot<TKey>
    {
        Task SaveAsync(TA aggregateRoot);
        Task<TA> GetByIdAsync(TKey key);
    }
}