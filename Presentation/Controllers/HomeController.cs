using Microsoft.AspNetCore.Mvc;
using Event.Models;
using Event.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Event.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Event.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;
    public HomeController(ApplicationDbContext context, UserManager<AppUser> userManager, IConfiguration configuration)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var events = await _context.Events.ToListAsync();
        var organizers = await _context.Organizers.ToListAsync();

        var trendingEvents = events.Where(e => e.LikesCount > 1).ToList();

        // Categorize events
        var techEvents = events.Where(e => e.Category == "Tech").ToList();
        var musicEvents = events.Where(e => e.Category == "Music").ToList();
        var onlineEvents = events.Where(e => e.Category == "Online").ToList();


        var viewModel = new MainPageViewModel
        {
            AllEvents = events.Select(e => new EventDisplayViewModel { Event = e, IsRsvped = false }).ToList(),
            TrendingEvents = trendingEvents.Select(e => new EventDisplayViewModel { Event = e, IsRsvped = false }).ToList(),
            TechEvents = techEvents.Select(e => new EventDisplayViewModel { Event = e, IsRsvped = false}).ToList(),
            MusicEvents = musicEvents.Select(e => new EventDisplayViewModel { Event = e, IsRsvped = false }).ToList(),
            OnlineEvents = onlineEvents.Select(e => new EventDisplayViewModel { Event = e, IsRsvped = false }).ToList(),
            Organizers = organizers
        };

        return View(viewModel);


    }



}
