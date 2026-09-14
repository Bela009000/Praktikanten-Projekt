namespace Lernkarten.Api.Models;

public sealed class Card
{
    public Guid Id { get; init; }
    public Guid SetId { get; init; }
    public required string Front { get; set; }
    public required string Back { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
}
