using CodingKata.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata.Common
{
    public class SendGridService : IEmailService
    {
        public Task SendMail(EmailMessage emailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
