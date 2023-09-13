namespace SOLID.DIP.Violation;

public class ClientService
{
    public string AddClient(Client client)
    {
        if (!client.Validate())
            return "Invalid Data";

        var repo = new ClientRepository();
        repo.AddClient(client);

        EmailServices.Send("company@company.com", client.Email.Address, "Welcome", "Congratulations for your Registered");

        return "Client registered with success";
    }
}