using System.Threading;
using System.Threading.Tasks;
using TalisSoft.Common.Application.Models.Mail;

namespace TalisSoft.Common.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task Send(Email email, CancellationToken cancellationToken);
    }
}