namespace SOLID.LSP.Violation;

public class CalculateArea
{
    private static void ObtainRectangleArea(Rectangle rectangle)
    {
        Console.Clear();
        Console.WriteLine("Rectangle area");
        Console.WriteLine();
        Console.WriteLine(rectangle.Height + " * " + rectangle.Height);
        Console.WriteLine();
        Console.WriteLine(rectangle.Area);
        Console.ReadKey();
    }

    public static void Calculate()
    {
        var square = new Square()
        {
            Height = 10,
            Width = 5
        };
        
        
        // Below we're violating LSP because Square is not a Rectangle and do not act like it either.
        
        ObtainRectangleArea(square);
    }
    
    
}