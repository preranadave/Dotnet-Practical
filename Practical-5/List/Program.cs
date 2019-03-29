using System;
using System.IO;
class MyClass
{
    public static void Main()
    {
        string[] Directories = Directory.GetDirectories(@"D:\DOT NET");
        foreach (string dir in Directories)
            Console.WriteLine(dir);
        string[] files = Directory.GetFiles(@"D:\DOT NET");
        foreach (string file in files)
            Console.WriteLine(file);

    }
}