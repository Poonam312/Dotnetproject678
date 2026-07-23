
public class AsyncAwaitt
{
    static void Main()
    {
        
static async Task Main()
    {
        Console.WriteLine("Loading employee details");
    
        await Loademployee();

         Console.WriteLine("completed"); 

        }  
         static async Task Loademployee()
            {
                await Task.Delay(3000);
                Console.WriteLine("employee loaded");
            }
        }
}


