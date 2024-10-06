using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Interfaces;

namespace Event.Services.EmailService
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;
        public EmailSender(EmailConfiguration emailConfig)
    {
        _emailConfig = emailConfig;
    }
        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }
    }
}