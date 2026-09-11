namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, GIT!");
        Console.WriteLine(Firstmethod("Nan"));
    }
    static string Firstmethod(string name)
    {
        return $"Hello { name}";
    }
}
