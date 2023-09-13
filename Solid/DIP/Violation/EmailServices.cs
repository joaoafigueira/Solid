using System.Net.Mail;

namespace SOLID.DIP.Violation;

public static class EmailServices
{
    public static void Send(string from, string to, string subject, string message)
    {
        var email = new MailMessage(to, from);
        var client = new SmtpClient()
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        email.Subject = subject;
        email.Body = message;
        client.Send(email);
    }
}