
delegate void Methoddele(string msg);
class Delegateeg
{
    static void display(string message)
    {
        Console.WriteLine(message);
    }
    static void Main()
    {
        Methoddele  M= display;
        M("hello i am learning c#");
    }
}

