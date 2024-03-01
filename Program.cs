internal class Program
{
    //class Student
    //{
    //    private string name;
    //    private int scienceGrade;
    //    private int mathGrade;
    //    private int englishGrade;

    //    public string Name { get { return name; } }

    //    public Student(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void SetGrades(int scienceGrade, int mathGrade, int englishGrade)
    //    {
    //        this.scienceGrade = scienceGrade;
    //        this.mathGrade = mathGrade;
    //        this.englishGrade = englishGrade;
    //    }

    //    public double CalculateAverageGrade()
    //    {
    //        return (scienceGrade + mathGrade + englishGrade) / 3.0;
    //    }

    //    public void DisplayStudentInfo()
    //    {
    //        Console.WriteLine($"Name: {name}");
    //        Console.WriteLine($"Science Grade: {scienceGrade}");
    //        Console.WriteLine($"Math Grade: {mathGrade}");
    //        Console.WriteLine($"English Grade: {englishGrade}");
    //        Console.WriteLine($"Average Grade: {CalculateAverageGrade()}\n");
    //    }
    //}
    static void Main(string[] args)
    {
        int choice = 0;

        Console.WriteLine("\nWelcome to the Student Grades System! \n");
        Console.WriteLine("[1]Enroll Students");
        Console.WriteLine("[2]Enter Student Grades");
        Console.WriteLine("[3]Show Student Grades");
        Console.WriteLine("[4]Show Top Student");
        Console.WriteLine("[5]Exit");

        Console.Write("\nEnter Choice: ");
        choice = int.Parse(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                Console.Write("Enroll Students");
                break;
            case 2:
                Console.Write("Enter Student Grades");
                break;
            case 3:
                Console.Write("Show Student Grades");
                break;
            case 4:
                Console.Write("Show Top Student");
                break;
            case 5:
                Console.Write("Exit");
                break;
        }
    }

    //static void EnrollStudents(Student[] students)
    //{
    //    for (int i = 0; i < students.Length; i++)
    //    {
    //        Console.Write($"Enter name of student {i + 1}: ");
    //        string name = Console.ReadLine();
    //        students[i] = new Student(name);
    //    }
    //}

}