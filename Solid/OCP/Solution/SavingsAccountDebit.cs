namespace SOLID.OCP.Solution;

public class SavingsAccountDebit : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Action
        
        return FormatTransaction();
    }
}