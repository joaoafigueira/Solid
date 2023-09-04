namespace SOLID.OCP.Solution;

public class InvestmentAccountDebit : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Action

        return FormatTransaction();
    }
}