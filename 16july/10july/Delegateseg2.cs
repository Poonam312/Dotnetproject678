
delegate void Methoddele();
class Delegateseg2
{
static void display()
    {
        Console.WriteLine("method1:hello learning .net");
    }
static void show()
    {
        Console.WriteLine("method2:hello learning .net");
    }
    static void show1()
    {
        Console.WriteLine("method3:hello learning .net");
    }
     static void Main()
    {
        Methoddele M= display;
        M+=show;
        M+=show1;
        M();
        
    }

}
