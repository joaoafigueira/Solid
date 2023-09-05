namespace SOLID.LSP.Solution;

public class CalculateArea
{
    private static void ObtainParallelogramArea(Parallelogram parallelogram)
    {
        Console.Clear();
        Console.WriteLine("Calculo da área do Retangulo");
        Console.WriteLine();
        Console.WriteLine(parallelogram.Height + " * " + parallelogram.Width);
        Console.WriteLine();
        Console.WriteLine(parallelogram.Area);
        Console.ReadKey();
    }

    public static void Calculate()
    {
        var square = new Square(5, 5);
        var rectangle = new Rectangle(10, 5);
        
        ObtainParallelogramArea(square);
        ObtainParallelogramArea(rectangle);
    }
    
}