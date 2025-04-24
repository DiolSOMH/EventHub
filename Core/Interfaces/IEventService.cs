using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Models;

namespace Event.Core.Interfaces
{
    public interface IEventService
    {
        Task<List<Eventt>> GetAllEventsAsync();
        Task<Eventt?> GetEventByIdAsync(int eventId);
        Task<bool> RSVPEventAsync(int eventId, string userId);
        Task<bool> IsUserRSVPedAsync(int eventId, string userId);
        Task CreateEventAsync(Eventt newEvent);


    }
}