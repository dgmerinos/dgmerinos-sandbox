using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        JsonSerializer serializer = new JsonSerializer();
       
        var json = "{}";
        JsonReader reader = new JsonTextReader(new StringReader(json));
        object? whatIsThis = serializer.Deserialize(reader, typeof(Order));
        if(whatIsThis == null)
        {
            return;
        }
        Console.WriteLine("The given JSON String was converted to an object, here is the string representation: ");
        Console.WriteLine(whatIsThis);
    }
}

internal class Order
{
    public string order_id { get; set; }
    public string client_reference_id { get; set; }
    public string client_id { get; set; }
    public Status order_status { get; set; }
}

internal class Status
{
    public int status_id { get; set; }
    public string status { get; set; }
}