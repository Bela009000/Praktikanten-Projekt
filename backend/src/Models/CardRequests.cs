namespace Lernkarten.Api.Models;

public sealed record CreateCardRequest(Guid SetId, string Front, string Back);
public sealed record UpdateCardRequest(string Front, string Back);
