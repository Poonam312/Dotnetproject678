

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public virtual void Display()
    {
        Console.WriteLine("Id : " + Id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Monthly : " + Salary);
        Console.WriteLine("Annual : " + Salary * 12);
    }
}

class .cs : Employee
{
    public string Department { get; set; }

    public Manager(int id, string name, double salary, string department)
        : base(id, name, salary)
    {
        Department = department;
    }

    public override void Display()
    {
        Console.WriteLine("Id : " + Id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Monthly : " + Salary);
        Console.WriteLine("Annual : " + Salary * 12);
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        List<Manager> managers = new List<Manager>();

        while (true)
        {
            Console.WriteLine("\nWelcome to Emp System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Manager");
            Console.WriteLine("3. View Employee");
            Console.WriteLine("4. View Manager");
            Console.WriteLine("5. Search Employee");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Choice 1-6 : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Employee ID : ");
                    int eid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name : ");
                    string ename = Console.ReadLine();

                    Console.Write("Enter Salary : ");
                    double esalary = Convert.ToDouble(Console.ReadLine());

                    employees.Add(new Employee(eid, ename, esalary));

                    Console.WriteLine("Employee Added Successfully");
                    break;

                case 2:
                    Console.Write("Enter Manager ID : ");
                    int mid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name : ");
                    string mname = Console.ReadLine();

                    Console.Write("Enter Salary : ");
                    double msalary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Department : ");
                    string dept = Console.ReadLine();

                    managers.Add(new Manager(mid, mname, msalary, dept));

                    Console.WriteLine("Manager Added Successfully");
                    break;

                case 3:
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No Employee Found");
                    }
                    else
                    {
                        foreach (Employee e in employees)
                        {
                            e.Display();
                            Console.WriteLine("-------------------------");
                        }
                    }
                    break;

                case 4:
                    if (managers.Count == 0)
                    {
                        Console.WriteLine("No Manager Found");
                    }
                    else
                    {
                        foreach (Manager m in managers)
                        {
                            m.Display();
                        }
                    }
                    break;

                case 5:
                    Console.Write("Enter Employee ID : ");
                    int search = Convert.ToInt32(Console.ReadLine());

                    bool found = false;

                    foreach (Employee e in employees)
                    {
                        if (e.Id == search)
                        {
                            e.Display();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Employee Not Found");
                    }
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
