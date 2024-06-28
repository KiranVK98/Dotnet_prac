using System;
using System.Collections.Generic;

public class Addition() : Calculate
{
    public double Calculate_op(double a, double b)
    {
        return a+b;
    }


}


public class Subtraction() : Calculate
{
    public double Calculate_op(double a, double b)
    {
        return a-b;
    }


}

public class Multiply() : Calculate
{
    public double Calculate_op(double a, double b)
    {
        return a*b;
    }


}


public class Divide() : Calculate
{
    public double Calculate_op(double a, double b)
    {
        return a/b;
    }


}