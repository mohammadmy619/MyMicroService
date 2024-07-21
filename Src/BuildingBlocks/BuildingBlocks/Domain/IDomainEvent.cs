namespace BuildingBlocks.Domain;
public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}
