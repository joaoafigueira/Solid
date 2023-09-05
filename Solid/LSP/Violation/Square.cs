namespace SOLID.LSP.Violation;

// LSP says subtypes can be replaced by their subtypes, and below we have with this principle.

public class Square : Rectangle
{
    public override double Height
    {
        set { base.Height = base.Height = value; }
    }

    public override double Width
    {
        set { base.Width = base.Width = value; }
    }
}