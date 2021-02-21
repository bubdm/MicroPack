using System.Threading.Tasks;
using MicroPack.Domain;

namespace MicroPack.EventStore
{
    public interface IEventsRepository<TA, in TKey>
        where TA : class, IAggregateRoot<TKey>
    {
        Task AppendAsync(TA aggregateRoot);
        Task<TA> RehydrateAsync(TKey key);
    }
}