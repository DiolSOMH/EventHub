using Event.Models;

public interface IServiceRepository
{
    Task<List<ServiceProposal>> GetAllAsync();
    Task AddAsync(ServiceProposal serviceModel);

    Task DeleteAsync (int id);

}