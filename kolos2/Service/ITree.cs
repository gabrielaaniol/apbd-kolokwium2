using kolos2.DTOs;

namespace kolos2.Service;

public interface ITree
{
    Task<TreeWithResponsible> GetPlayerWithMatchesAsync(int playerId);
    Task AddPlayerWithMatchesAsync(AddTreeDto dto);
    Task AddTree(AddTreeDto dto);
    Task<object?> GetTree(int id);
}   