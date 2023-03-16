namespace Domain.Interfaces
{
    internal interface IDomainEventHandler<T> where T : IDomainEvent
    {
        internal void Apply(T @event);
    }
}
