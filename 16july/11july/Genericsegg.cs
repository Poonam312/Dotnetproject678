
 class Genericsegg<T>
{
   public void print(T value)
    {
        Console.WriteLine(value);
    } 
}
class Genericsegg
{

    static void Main()
    {
    
    
    Genericsegg <string> g1=new Genericsegg <string>();
    g1.print("poonam");
    
    
    Genericsegg <int> g2 =new Genericsegg <int>();
    g2.print(123);
    
    
    }

    }


