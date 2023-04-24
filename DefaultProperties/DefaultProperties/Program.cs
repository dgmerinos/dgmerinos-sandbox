using DefaultProperties;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

MyClass instance = new();

Console.WriteLine("Instance properties:\n");
Console.WriteLine($"Name: {instance.Name}");
Console.WriteLine($"Age: {instance.Age}");
Console.WriteLine($"City of Birth: {instance.CityOfBirth}");

MyInitializedClass initializedInstance = new();

Console.WriteLine("Instance properties:\n");
Console.WriteLine($"Name: {initializedInstance.Name}");
Console.WriteLine($"Age: {initializedInstance.Age}");
Console.WriteLine($"City of Birth: {initializedInstance.CityOfBirth}");

initializedInstance.Name = "David";
initializedInstance.Age = 29;


string serializedObject = JsonConvert.SerializeObject(initializedInstance);

MyInitializedClass? receiver = JsonConvert.DeserializeObject<MyInitializedClass>(serializedObject);

return 0;
