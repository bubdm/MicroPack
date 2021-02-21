using System.Collections.Generic;

namespace MicroPack.Domain
{
    public interface IAggregateRoot<out TKey> : IEntity<TKey>
    {
        long Version { get; }
        IEnumerable<IDomainEvent<TKey>> Events { get; }
        void ClearEvents();
    }
}