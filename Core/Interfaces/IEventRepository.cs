using Event.Models;

public interface IEventRepository
{
    Task<List<Eventt>> GetAllAsync();
    Task<Eventt?> GetEventById(int id);
    Task<List<Eventt>> GetByCategoryAsync(string category);
    Task AddAsync(Eventt eventModel);

    Task DeleteAsync (int id);

}