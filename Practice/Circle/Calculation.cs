using System.Collections.Generic;
using System;

public class Calculations : ICalculation
{
    public double radiuss {get;set;}
    public Calculations(double radius)
    {
        radiuss = radius;
    }

    public double calculateArea()
    {
        return Math.PI*radiuss*radiuss;
    }
}

public class Rectangle : ICalculation
{
    private double lengths{get; set;}
    private double breadths{get;set;}
    public Rectangle(double length, double breadth)
    {
        lengths = length;
        breadths = breadth;
    }

    public double calculateArea()
    {
        return lengths*breadths;
    }
}