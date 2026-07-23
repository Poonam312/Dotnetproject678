//events //

delegate void Methoddele();
class Button
{
  //event declaration
  public  event  Methoddele Click;
  // event//
  public void Buttonpress()
    {
        Console.WriteLine("button is pressed");
        Click?.Invoke();
    }
   static void Main()
    {
        
    //event handler methods//
    void login()
    {
       Console.WriteLine("login successfully");
    }
    void accountcreate()
    {
        Console.WriteLine("account created");

        
    }
    Button b=new Button();
    b.Click+=login;
    b.Click+=accountcreate;
    b.Buttonpress();
    }

}

