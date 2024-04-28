namespace Eda.Messaging.Contracts.Inbound;

public record CheckGenerationCompleted
{
    public Guid Id { get; init; }
    public DateTime GenerationDate { get; init; }
}
