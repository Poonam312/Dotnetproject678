//Open Close principle-open for extension and close for modification//
interface Student
{
    public void studentdata();
    public void studentrollno();
}
class Student1 : Student
{
    void studentdata()
    {
        Console.WriteLine("it contains the data of the student1");
    }
    void studentrollno()
    {
        Console.WriteLine("it contains the rollno of the student1");

    }
    
}
class Student2 : Student
{
    void studentdata()
    {
        Console.WriteLine("it contains the data of the student2");
    }
    void studentrollno()
    {
        Console.WriteLine("it contains the rollno of the student2");

    }
}