using System.Text.Json;
public class Serializationeg
{
    int id{get;set;}
    string name{grt;set;}
    
    static void Main()
    {
        Serializationeg s=new Serializationeg();
        s.id=100;
        s.name="poonam";
        string json=JsonSerializer.Serialize(s);
        File.WriteAllLines("Serializationeg.json",json);
    }
}