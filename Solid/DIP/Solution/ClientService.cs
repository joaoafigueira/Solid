using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IEmailService _emailService;


    public ClientService(IEmailService emailService, IClientRepository clientRepository)
    {
        _emailService = emailService;
        _clientRepository = clientRepository;
    }

    public string AddClient(Client client)
    {
        if (!client.Validate())
            return "Invalid Data";
        
        _clientRepository.AddClient(client);
        
        _emailService.Send("company@company.com", client.Email.Address, "Welcome", "Congratulations for your register.");

        return "Client registered with Success.";
    }
}