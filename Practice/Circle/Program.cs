// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        List<ICalculation> calci = new List<ICalculation>();
        calci.Add(new Calculations(3));
        calci.Add(new Calculations(5));
        calci.Add(new Rectangle(2,3));
        calci.Add(new Rectangle(5,6));
        foreach(var pt in calci)
        {
            Console.WriteLine($"The area of {pt.GetType()} is {pt.calculateArea()}");
        }
    }
}
