public class Student : Person
{

    private double _gpa;

    public static int StudentCount { get; private set; } = 0;
    public double GPA
    {
        get { return _gpa; }
        set
        {
            if (value < 0 || value > 4)
                throw new ArgumentException("GPA must be between 0 and 4.");
            _gpa = value;

        }
    }

    public Student() : this("Unknown", 1, 0.0) { }


    public Student(string name, int age, double gpa) : base(name, age)
    {
        this.GPA = gpa;
        StudentCount++;
    }

    public Student(Student s) : this(s.Name, s.Age, s.GPA) { }


    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"GPA: {GPA}, Grade: {CalculateGrade()}");
    }


    public String CalculateGrade()
    {
        switch (this.GPA)
        {
            case >= 3.5:
                return "Excellent";
            case >= 3.0:
                return "Very Good";
            case >= 2.5:
                return "Good";
            case >= 2.0:
                return "Pass";
            default:
                return "Fail";

        }

    }
}