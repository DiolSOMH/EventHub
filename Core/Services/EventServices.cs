using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.Interfaces;
using Event.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Event.Core.Services
{
    public class EventServices : IEventService
    {
        public readonly IEventRepository _eventRepository;
        public EventServices(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task CreateEventAsync(Eventt eventModel)
        {
            await _eventRepository.AddAsync(eventModel);
        }

        public async Task<List<Eventt>> GetAllEventsAsync()
        {
            return await _eventRepository.GetAllAsync();
        }

        public async Task<Eventt?> GetEventByIdAsync(int eventId)
        {
            return await _eventRepository.GetEventById(eventId);
        }

        public Task<bool> IsUserRSVPedAsync(int eventId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RSVPEventAsync(int eventId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}