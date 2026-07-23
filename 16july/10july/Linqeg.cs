

public class Linqeg
{
static void Main()
    {
        int []num={4,7,8,8,6,4,2};
        var even=num.Where(x=>x%2==0);
        foreach(var n in even)
        {

       Console.WriteLine(n);
        } 
}
}

