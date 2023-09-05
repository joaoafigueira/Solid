﻿namespace SOLID.LSP.Solution;

// Here the LSP Principle it is maintained, because a square and a Rectangle are parallelograms and act like too.

public abstract class Parallelogram
{
    protected Parallelogram(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public double Height { get; set; }
    
    public double Width { get; set; }
    
    public double Area { get { return Height * Width; } } 
}