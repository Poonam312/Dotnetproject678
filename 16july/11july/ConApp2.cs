
class ConApp2
{
    public int Id { get; set; }
    public string EmpName { get; set; }
    public double MonthlySalary { get; set; }

    public ConApp2(int i, string e, double s)
    {
        Id = i;
        EmpName = e;
        MonthlySalary = s;
    }

    public double CalculateAnnualSalary()
    {
        return MonthlySalary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Id : " + Id);
        Console.WriteLine("Name : " + EmpName);
        Console.WriteLine("Monthly Salary : " + MonthlySalary);
        Console.WriteLine("Annual Salary : " + CalculateAnnualSalary());
    }
}
