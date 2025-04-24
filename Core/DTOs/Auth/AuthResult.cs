using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Core.DTOs.Auth
{
    public class AuthResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }


        public AuthResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

}