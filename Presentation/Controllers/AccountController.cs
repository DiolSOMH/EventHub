using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.DTOs.Auth;
using Event.Core.Interfaces;
using Event.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Event.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;
        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest model)
        {
            await _authService.LoginAync(model);
            return RedirectToPage("Index");
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterRequest model)
        {
            await _authService.RegisterAsync(model);
            return RedirectToPage("Index");
        }
        
    }
}