namespace SOLID.OCP.Solution;

public class CurrentAccountDebit : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Action
        
        return FormatTransaction();
    }
}