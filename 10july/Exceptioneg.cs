class Exceptioneg
{
    static void Main()
    {
    
            
        try
        {
    
            int a=2;
            int b=0;
            int c=a/b;

           Console.WriteLine(c);
            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block will execute always");
        }
    }
}