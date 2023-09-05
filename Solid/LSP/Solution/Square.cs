namespace SOLID.LSP.Solution;

public class Square : Parallelogram
{
    public Square(int height, int width) : base(height, width)
    {
        if (height != width)
            throw new ArgumentException("The two sides can not be equal");
    }
}