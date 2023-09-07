namespace SOLID.ISP.Violation;

public class RegisterProduct : IRegister
{
    public void ValidateData()
    {
        //Action
    }

    public void Save()
    {
        //Action
    }

    public void SendEmail()
    {
        // Product does not send an email, this proves that the ISP Principle is being broken, and it is an interface leak.
    }
}