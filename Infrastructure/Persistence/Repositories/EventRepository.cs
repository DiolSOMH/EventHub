using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Data;
using Event.Models;
using Microsoft.EntityFrameworkCore;

namespace Event.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {

        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Eventt eventModel)
        {
            await _context.Events.AddAsync(eventModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var eventEntity = await _context.Events.FindAsync(id);
            if (eventEntity != null)
            {
                _context.Events.Remove(eventEntity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Eventt>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<List<Eventt>> GetByCategoryAsync(string category)
        {
            return await _context.Events.Where(e => e.Category == category).ToListAsync();
        }

        public async Task<Eventt?> GetEventById(int id)
        {
            return await _context.Events.FindAsync(id);
        }
    }
}