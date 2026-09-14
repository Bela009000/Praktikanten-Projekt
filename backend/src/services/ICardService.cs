using Lernkarten.Api.Models;

namespace Lernkarten.Api.Services;

public interface ICardService
{
    IReadOnlyCollection<Card> GetAll(Guid? setId);
    Card? GetById(Guid id);
    Card Create(CreateCardRequest request);
    Card? Update(Guid id, UpdateCardRequest request);
    bool Delete(Guid id);
}
