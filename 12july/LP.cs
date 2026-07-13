
//liskov substitution principle-your derived class must be replacable by the base class.//

using System;

abstract class Bird
{
    public abstract void Fly();
    public abstract void Color();
}

class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow can fly");
    }

    public override void Color()
    {
        Console.WriteLine("Sparrow is black");
    }
}

class Program
{
    static void Main()
    {
        Bird b = new Sparrow();

        b.Fly();
        b.Color();
    }
}
