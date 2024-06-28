using System;
using System.Collections.Generic;

public class ToDo
{
    private List<ITask> tasks = new List<ITask>();

    private int nextId = 0;

    public void AddTask(string description)
    {
        tasks.Add(new task(++nextId, description));
    }

    public void ListTask()
    {
        foreach(var task in tasks)
        {
            Console.WriteLine(task.Description);
            Console.WriteLine(task);
        }
    }

    public ITask findTaskById(int id)
    {
        return tasks.Find(task => task.Id == id);
    }
}