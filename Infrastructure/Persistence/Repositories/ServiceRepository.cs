using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Data;
using Event.Models;
using Microsoft.EntityFrameworkCore;

namespace Event.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {

        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ServiceProposal serviceModel)
        {
            await _context.AddAsync(serviceModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var serviceModel = await _context.ServiceProposals.FindAsync(id);
            if (serviceModel!= null)
            {
                _context.ServiceProposals.Remove(serviceModel);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<ServiceProposal>> GetAllAsync()
        {
            return await _context.ServiceProposals.ToListAsync();
        }

    }
}