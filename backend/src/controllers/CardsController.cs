using Lernkarten.Api.Models;
using Lernkarten.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lernkarten.Api.Controllers;

[ApiController]
[Route("api/cards")]
public sealed class CardsController(ICardService cardService) : ControllerBase
{
    [HttpGet]
    public ActionResult<IReadOnlyCollection<Card>> GetAll([FromQuery] Guid? setId)
        => Ok(cardService.GetAll(setId));

    [HttpGet("{id:guid}")]
    public ActionResult<Card> GetById(Guid id)
    {
        var card = cardService.GetById(id);
        return card is null ? NotFound() : Ok(card);
    }

    [HttpPost]
    public ActionResult<Card> Create(CreateCardRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Front) || string.IsNullOrWhiteSpace(request.Back))
        {
            return BadRequest("Front und Back dürfen nicht leer sein.");
        }

        var card = cardService.Create(request);
        return CreatedAtAction(nameof(GetById), new { id = card.Id }, card);
    }

    [HttpPut("{id:guid}")]
    public ActionResult<Card> Update(Guid id, UpdateCardRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Front) || string.IsNullOrWhiteSpace(request.Back))
        {
            return BadRequest("Front und Back dürfen nicht leer sein.");
        }

        var card = cardService.Update(id, request);
        return card is null ? NotFound() : Ok(card);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
        => cardService.Delete(id) ? NoContent() : NotFound();
}
