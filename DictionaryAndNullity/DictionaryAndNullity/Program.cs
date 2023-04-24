// See https://aka.ms/new-console-template for more information
Dictionary<int, int>? dict = new Dictionary<int, int>();
dict.Add(0, 1);
dict.Add(1, 2); 
//dict = null;

if (dict?[0] == null)
{
    Console.WriteLine("Value of dict: {0}", dict);
} else
{
    Console.WriteLine(dict[0]); 
}

