﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SendEmails.Services
{
    public interface IMailingService
    {
        Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachments = null);

    }
}
