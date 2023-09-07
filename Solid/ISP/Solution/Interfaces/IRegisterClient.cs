namespace SOLID.ISP.Solution.Interfaces;

public interface IRegisterClient : IRegister
{
    void ValidateDate();
    void SendEmail();
}