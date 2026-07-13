
public class Lamdaexpression
{
   static void Main()
    {
        

Func<int,int>square=x=>x*x;
Console.WriteLine(square(4));


Func<int,int,int>add=(a,b)=>a+b;
Console.WriteLine(add(4,2));

Func<int,int,int>sub=(a,b)=>a-b;
Console.WriteLine(sub(4,2));


    }
}
