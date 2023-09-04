namespace SOLID.OCP.Violation;

public class DebitAccount
{
    public void Debit(decimal value, string account, AccountType accountType)
    {
        if (accountType == AccountType.Checking)
        {
            // Action
        }

        if (accountType == AccountType.Saving)
        {
            // Action
        }
    }
}