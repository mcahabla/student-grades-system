using System;

class Student
{
    public string Name { get; set; }
    public double ScienceGrade { get; set; }
    public double MathGrade { get; set; }
    public double EnglishGrade { get; set; }

    //calculate the average grade of student and round off the result to 2 decimal places
    public double AverageGrade
    {
        get { return Math.Round((ScienceGrade + MathGrade + EnglishGrade) / 3, 2); }
    }

    //string interpolation for formatting the output of the grades
    public override string ToString()
    {
        return $"{Name,-15} {ScienceGrade,-10} {MathGrade,-6} {EnglishGrade,-9} {AverageGrade,-4}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------\n");

        //enter number of students to enroll
        Console.Write("Enter total number of students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        //creates an array with size specified by totalStudent
        Student[] students = new Student[totalStudents];
        int enrolledStudents = 0;

        while (true)
        {
            Console.Write("\n");
            Console.WriteLine("\nWelcome to the Student Grades System!");
            Console.WriteLine("[1] Enroll Students");
            Console.WriteLine("[2] Enter Student Grades");
            Console.WriteLine("[3] Show Student Grades");
            Console.WriteLine("[4] Show Top Student");
            Console.WriteLine("[5] Exit");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            //switch statement 
            switch (choice)
            {
                case 1:

                    //ensures that the enrolledStudents do not exceeds the number of totalStudents
                    if (enrolledStudents < totalStudents)
                    {
                        EnrollStudent(students, ref enrolledStudents);
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot exceed total number of students");
                    }
                    break;
                case 2:
                    EnterStudentGrades(students);
                    break;
                case 3:
                    ShowStudentGrades(students);
                    break;
                case 4:
                    ShowTopStudent(students, enrolledStudents);
                    break;
                case 5:
                    Console.WriteLine("\nBye!");
                    return;
                default:
                    //ensures that the users enter a number between 1-5 only
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    static void EnrollStudent(Student[] students, ref int enrolledStudents)
    {
        Console.Write("\n");
        Console.WriteLine("\nEnroll Student");
        Console.Write("Enter student name: ");

        //user enters the name of the student and then the student object is added to the students array
        students[enrolledStudents] = new Student { Name = Console.ReadLine() };
        enrolledStudents++;
        char choice;
        do
        {
            Console.Write("Enter Again[Y/N]: ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
        } while (choice != 'Y' && choice != 'N');

        if (choice == 'Y')
        {
            if (enrolledStudents < students.Length)
            {
                EnrollStudent(students, ref enrolledStudents);
            }
            else
            {
                Console.WriteLine("\nError: Cannot exceed total number of students");
            }
        }
    }

    //allows the user to input each grade for science, math and english
    static void EnterStudentGrades(Student[] students)
    {
        foreach (var student in students)
        {
            Console.Write("\n");
            Console.WriteLine($"\nStudent: {student.Name}");
            Console.Write("Enter grade for Science: ");
            student.ScienceGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter grade for Math: ");
            student.MathGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter grade for English: ");
            student.EnglishGrade = double.Parse(Console.ReadLine());
            char choice;
            do
            {
                Console.Write("Enter Again[Y/N]: ");
                choice = char.ToUpper(Console.ReadKey().KeyChar);
            } while (choice != 'Y' && choice != 'N');

            if (choice == 'N')
            {
                break;
            }
        }
    }

    //prints each student's grades using foreach
    static void ShowStudentGrades(Student[] students)
    {
        Console.WriteLine("\nStudent Grades");
        Console.WriteLine("Name            Science   Math   English   Ave.");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    static void ShowTopStudent(Student[] students, int enrolledStudents)
    {
        if (enrolledStudents == 0)
        {
            Console.WriteLine("\nNo students enrolled yet.");
            return;
        }

        double maxAverage = double.MinValue;
        string topStudent = "";

        foreach (var student in students)
        {
            if (student != null && student.AverageGrade > maxAverage)
            {
                maxAverage = student.AverageGrade;
                topStudent = student.Name;
            }
        }

        //prints the name of the top performing student
        Console.WriteLine($"\nTop-performing student: {topStudent}");
    }
}
