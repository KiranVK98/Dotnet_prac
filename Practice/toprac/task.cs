using System;
using System.Collections.Generic;

public class task : ITask
{
    public int Id {get; set;} 

    public string Description {get;set;}

    public bool isCompleted {get;set;}

    public task(int id, string description)
    {
        Id = id;
        Description = description;

    }

    public void MarkAsCompleted()
    {
        isCompleted = true;
    }

    public override string ToString()
    {
        return $"id - {Id}. description - {Description} - completed :{(isCompleted ? "Completed" : "Pending")}";
    }
}