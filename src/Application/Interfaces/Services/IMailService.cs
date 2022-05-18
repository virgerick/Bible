using Bible.Application.Requests.Mail;

namespace Bible.Application.Interfaces.Services;

public interface IMailService
{
    Task SendAsync(MailRequest request);
}