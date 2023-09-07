namespace SOLID.ISP.Solution.Interfaces;

// Below we have an example of a skinny interface, that respects the ISP Principle.

// The proper way to respect ISP is to keep all common behaviors in a Interface, and specialize the individuals behaviors in individual interface.

public interface IRegister
{
    void Save();
}