using Lernkarten.Api.Models;

namespace Lernkarten.Api.Services;

public class UserStore
{
    public List<User> Users { get; } = new();
    private int _nextId = 1;

    public int GetNextId()
    {
        return _nextId++;
    }
}