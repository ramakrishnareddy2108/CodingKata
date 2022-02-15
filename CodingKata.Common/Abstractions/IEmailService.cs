using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata.Common.Abstractions
{
    public interface IEmailService
    {
        Task SendMail(EmailMessage emailMessage);
    }
}
