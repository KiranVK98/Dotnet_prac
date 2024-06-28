
public interface ITask 
{
    int Id {get; set;}
    string Description {get; set;}

    bool isCompleted {get; set;}

    void MarkAsCompleted();

}