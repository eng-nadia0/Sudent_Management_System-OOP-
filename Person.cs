
public class Person
{

    private string _name ="";

    protected int _age;


    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name must have a value.");
            }
            else
            {
                _name = value;
            }
        }
    }


    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be greater than 0.");
            }
            else
            {
                _age = value;
            }
        }
    }

    public Person() : this("Unknown", 1)
    {
    }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    //copy cons
    public Person(Person p) : this(p.Name, p.Age)
    {
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
    }

}


