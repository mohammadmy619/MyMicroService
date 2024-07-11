using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationServices
{
    public interface IEmailService
    {
        Task SendAsync(string email, string subject, string content, CancellationToken cancellationToken);
    }

}
