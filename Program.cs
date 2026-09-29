public class Program
{
       public static void Main()
    {
        try
        {


            Student st1 = new Student();
            Student st2 = new Student("Ahmed", 20, 3.8);
            Student st3 = new Student("Mohamed", 19, 2.5);
            Student st4 = new Student(st3);
            st4.Name = "Youssef (copy)";

            List<Person> StudentList = new List<Person> {
      new Person("Alice", 22),
    st1, st2, st3, st4,
    };
            foreach (var student in StudentList)
            {
                student.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine($"Total Students: {Student.StudentCount}");
            Console.WriteLine($"Original Student: Name: {st3.Name}, Age: {st3.Age}, GPA: {st3.GPA}");
            Console.WriteLine($"Copied Student: Name: {st4.Name}, Age: {st4.Age}, GPA: {st4.GPA}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine();

        try
        {
            Student st = new Student("Sara", -5, 3.0);
            st.ShowInfo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid Age Error: {ex.Message}");
        }
        Console.WriteLine();
        try
        {
            Student st = new Student("Omar", 21, 5.5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid GPA Error: {ex.Message}");
        }
    }
}