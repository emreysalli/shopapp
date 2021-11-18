using System.Threading.Tasks;

namespace shopapp.webui.EmailService
{
    public interface IEmailSender
    {
        //smtp =>gmail, hotmail
        //api=>sendgrid

        Task SendEmailAsync(string email, string subject, string htmlMessage);

    }
}