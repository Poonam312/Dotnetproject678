
public class Student
{
    int rollno;
    String name;
    String institute;
    long dob;
    char gender;
    float height;
    public Student(int rollno, string name, string institute, long dob, char gender, float height)
    {
        this.rollno = rollno;
        this.name = name;
        this.institute = institute;
        this.dob = dob;
        this.gender = gender;
        this.height = height;
    }


    public void display()
    {
    
    Console.WriteLine(rollno  +" "+name+" "+institute+" ");
    Console.WriteLine(dob+" "+gender+" "+height);
    }
    

}
