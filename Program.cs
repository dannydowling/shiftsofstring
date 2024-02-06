class Program { 

    static char cipher(char ch, int key)
    {
        if (!char.IsLetter(ch))
        {
            return ch;
        }

        char d = char.IsUpper(ch) ? 'A' : 'a';
        return (char)((((ch + key) - d) % 26) + d);
    }

    static string Encipher(string input, int key)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += cipher(ch, key);

        return output;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Type a string to encrypt:");
        string UserString = Console.ReadLine();

        Console.WriteLine("\n");


        Console.WriteLine("Encrypted Data");

        for (int i = 0; i < 26; i++)
        {
            string cipherText = Encipher(UserString, i);
            Console.WriteLine("Shifting by {0} gives {1}", i, cipherText);

        }
    }
}
