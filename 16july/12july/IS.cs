//Interface segretion principle-here client is not complusion to implement the method 
// of the interface if it do not use//
interface Iwork
{
    void Work();
    
}
interface Ieat
{
    void Eat();
}
class Human : Iwork,Ieat
{
    void Work()
    {
        Console.WriteLine("human works in the company");
    }
    void Eat()
    {
        Console.WriteLine("human eats in the company during break");
    }
}
class Robot:Iwork
{
     void Work()
    {
        Console.WriteLine("robots also works in the company");
    }
    
}