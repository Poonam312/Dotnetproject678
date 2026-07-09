
public class Conditionalstatements_loops
{ 
    static  void Main()
    {
        
    int marks=80;
    if(marks>=90&&marks<=100){
        Console.WriteLine("GRADE A");
    }
   else if(marks >=70 && marks <=80)
{
    Console.WriteLine("GRADE B");
}
else if (marks >= 45 && marks <=70)
        {
             Console.WriteLine("GRADE C");
        }
        else
        {
             Console.WriteLine("Fail");
        }


for(int num=1;num<=10;num++){
    Console.WriteLine(num);
}

int i=10;
while (i >= 0)
{
   Console.WriteLine(i); 
   i--;
}
int value=1;
do
{
    Console.WriteLine(value);
    value++;

}while(value<=5);

}

}

