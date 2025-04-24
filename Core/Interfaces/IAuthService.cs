using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.DTOs.Auth;

namespace Event.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> LoginAync(LoginRequest request);
        Task<AuthResult> RegisterAsync(RegisterRequest request);
    }
}