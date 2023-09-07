namespace SOLID.ISP.Violation;

// Below we have an example of a Fat Interface, that has methods that don't necessary belongs to it, breaking the ISP.

public interface IRegister
{
    void ValidateData();
    void Save();
    void SendEmail();
}