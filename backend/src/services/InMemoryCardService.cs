using System.Collections.Concurrent;
using Lernkarten.Api.Models;

namespace Lernkarten.Api.Services;

public sealed class InMemoryCardService : ICardService
{
    private readonly ConcurrentDictionary<Guid, Card> cards = new();

    public IReadOnlyCollection<Card> GetAll(Guid? setId)
    {
        return cards.Values
            .Where(card => setId is null || card.SetId == setId)
            .OrderBy(card => card.CreatedAt)
            .ToArray();
    }

    public Card? GetById(Guid id) => cards.TryGetValue(id, out var card) ? card : null;

    public Card Create(CreateCardRequest request)
    {
        var now = DateTimeOffset.UtcNow;
        var card = new Card
        {
            Id = Guid.NewGuid(),
            SetId = request.SetId,
            Front = request.Front,
            Back = request.Back,
            CreatedAt = now,
            UpdatedAt = now
        };

        cards[card.Id] = card;
        return card;
    }

    public Card? Update(Guid id, UpdateCardRequest request)
    {
        if (!cards.TryGetValue(id, out var card))
        {
            return null;
        }

        card.Front = request.Front;
        card.Back = request.Back;
        card.UpdatedAt = DateTimeOffset.UtcNow;
        return card;
    }

    public bool Delete(Guid id) => cards.TryRemove(id, out _);
}
