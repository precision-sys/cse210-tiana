using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job work in _jobs)
        {
            work.Display();
        }
    }
}