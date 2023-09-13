namespace SOLID.DIP.Solution.Interfaces;

// Create Interfaces it is the best way to respect the DIP Principle because the layers and the classes are going to exchange data using the interfaces
// causing less coupling.

public interface IClientRepository
{
    void AddClient(Client client);
}