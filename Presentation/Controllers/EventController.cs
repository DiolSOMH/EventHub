using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.Interfaces;
using Event.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Event.Presentation.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _eventService.GetAllEventsAsync();
            return View();
        }
    }
}