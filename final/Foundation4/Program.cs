using System;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("2025-10-01", 30, 5.0));
        activities.Add(new Cycling("2025-10-02", 45, 20.0));
        activities.Add(new Swimming("2025-10-03", 60, 40));


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}