using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.DTOs.Auth;
using Event.Core.Interfaces;
using Event.Models;
using Microsoft.AspNetCore.Identity;

namespace Event.Core.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthenticationService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<AuthResult> LoginAync(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null) return new AuthResult(false, "Invalid login");

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, true, false);
            if (!result.Succeeded) return new AuthResult(false, "Login failed");

            return new AuthResult(true, "Logged in");
        }

        public async Task<AuthResult> RegisterAsync(RegisterRequest request)
        {
            var user = new AppUser
            {
                Email = request.Email,
                UserName = request.UserName,
                
            };

            var createdUser = await _userManager.CreateAsync(user, request.Password);
            if(!createdUser.Succeeded)
            {
            
                return new AuthResult(false, "SignUp failed");
            }

            await _userManager.AddToRoleAsync(user, "User");
            return new AuthResult(true, "SignUp succesfull");
        }
    }
}