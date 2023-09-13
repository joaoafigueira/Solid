using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;

public class EmailService : IEmailService
{
    public void Send(string from, string to, string subject, string message)
    {
        throw new NotImplementedException();
    }
}