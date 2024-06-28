public class Program 
{
    public static void Main()
    {
        var app = new ToDo();
        app.AddTask("Learn C#");
        app.AddTask("Learn dot net core");
        app.AddTask("Ace amadeus");
        app.ListTask();
        ITask task = app.findTaskById(2);
        Console.WriteLine("this is your task"+task);
    }
}