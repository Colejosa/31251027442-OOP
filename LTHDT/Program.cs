using System;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

    // TODO: write instance methods here
    public string GetName()
    {
        return name;
    }
    public double GetScore()
    {
        return score;
    }
    public bool IsPassed()
    {
        return score >= 5.0;
    }
    public string GetClassification()
    {
        if (score >= 8.0)
            return "Excellent";
        else if (score >= 6.5)
            return "Good";
        else if (score >= 5.0)
            return "Average";
        else
            return "Weak";
    }
    // TODO: write static methods here
    public static int GetTotalStudents()
    {
        return totalStudents;
    }
    public static Student FindTopStudent(Student[] students)
    {
        if (students == null || students.Length == 0)
            return null;
        Student topStudent = students[0];
        foreach (Student student in students)
        {
            if (student.score > topStudent.score)
            {
                topStudent = student;
            }
        }
        return topStudent;
    }
    public static double CalculateAverageScore(Student[] students)
    {
        if (students == null || students.Length == 0)
            return 0.0;

        double totalScore = 0;

        foreach (Student student in students)
        {
            totalScore += student.score;
        }

        return totalScore / students.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // 1. Create an array of 5 Student objects
        Student[] students =
        {
            new Student("Anh", 8.5),
            new Student("Bao", 6.8),
            new Student("Chi", 4.5),
            new Student("Duong", 9.2),
            new Student("Hoang", 5.7)
        };

        // 2. Print total number of students
        Console.WriteLine("Total students: " + Student.GetTotalStudents());

        // 3. Print student list
        Console.WriteLine("\nStudent List:");

        foreach (Student student in students)
        {
            Console.WriteLine(
                "Name: " + student.GetName() +
                ", Score: " + student.GetScore() +
                ", Classification: " + student.GetClassification() +
                ", Status: " + (student.IsPassed() ? "Pass" : "Fail")
            );
        }

        // 4. Print the top-scoring student
        Student topStudent = Student.FindTopStudent(students);

        Console.WriteLine("\nTop Student:");
        Console.WriteLine("Name: " + topStudent.GetName());
        Console.WriteLine("Score: " + topStudent.GetScore());

        // 5. Print the class average score
        double average = Student.CalculateAverageScore(students);

        Console.WriteLine("\nClass Average: " + average);
    }
}