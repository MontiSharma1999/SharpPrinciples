﻿using SharpPrinciples.Geometry;

namespace SharpPrinciples.Shared;
public static class Printer
{
    public static void Print(IShape shape)
    {
        Console.WriteLine(shape);
    }
}
