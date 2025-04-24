using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Event.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            var features = new List<ServicePageViewModel>
            {
                new ServicePageViewModel 
                { 
                    Title = "Visibility Boost", 
                    Description = "Get your services in front of event organizers actively seeking partners." 
                },
                new ServicePageViewModel 
                { 
                    Title = "Tailored Matching", 
                    Description = "We match your services with events where you're most likely to be needed." 
                },
                new ServicePageViewModel 
                { 
                    Title = "Promotion Support", 
                    Description = "We promote your service on event pages and through our physical outreach." 
                },
                new ServicePageViewModel 
                { 
                    Title = "Credibility & Trust", 
                    Description = "Being on EventHub builds trust with organizers and attendees." 
                }
            };
            return View(features);
        }
    }
}