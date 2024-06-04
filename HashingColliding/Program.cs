namespace HashingColliding
{
    internal class Program
    {
        static string[] storage = new string[1000];
        static void Main(string[] args)
        {
            string name = "Dan";
            int result = getHashKey(name);
            storage[result] = name;
            Console.WriteLine($"{name} is stored at {result}");

            name = "Dna";
            result = getHashKey(name);
            storage[result] = name;
            Console.WriteLine($"{name} is stored at {result}");

            name = "Trevor";
            result = getHashKey(name);
            storage[result] = name;
            Console.WriteLine($"{name} is stored at {result}");

            name = "Bob";
            result = getHashKey(name);
            storage[result] = name;
            Console.WriteLine($"{name} is stored at {result}");
        }
        static int getHashKey(string name)
        {
            char c;
            int ASCIITotal = 0;
            for (int i = 0; i < name.Length; i++)
            {
                c = (char)name[i];
                ASCIITotal += (int)c;
            }
            return ASCIITotal % storage.Length;
        }
    }
}
