using System;
using AssignmentSummary;



class Program
{
    static void Main(string[] args)
    {
      Assignment first = new Assignment("Tiana Andri", "Calculus");
      Console.WriteLine(first.GetSummary());

      MathExercise Mathmatics = new MathExercise("Nancy Noro", "Algebra", "10.5", "6-10");
      Console.WriteLine(Mathmatics.GetSummary());
      Console.WriteLine(Mathmatics.GetHomeworkList());

      WritingAssignment Writing = new WritingAssignment ("Diary Miasy", "Personal Finance Improvement", "The Richest Man in Babylon");
      Console.WriteLine(Writing.GetwritingInformation());
      Console.WriteLine(Writing.GetSummary());
    }
}





