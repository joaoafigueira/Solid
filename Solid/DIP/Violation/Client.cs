namespace SOLID.DIP.Violation;

// Below we have a lot of Coupling breaking the DIP Principle.

public class Client
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public CPF Cpf { get; set; }
    public DateTime RegisterDate { get; set; }

    public bool Validate()
    {
        return Email.Validate() && Cpf.Validate();
    }
    
    
    
}