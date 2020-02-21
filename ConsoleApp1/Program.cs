using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currDir = ".";

            if (args.Length < 1)
            {
                Console.WriteLine("Pass direcotry to enumerate as first parameter!");
            }
            else
            {
                currDir = args[0];
            }

            DirectoryInfo dir = new DirectoryInfo(currDir);
            StlReader r = new StlReader();

            foreach (var x in dir.EnumerateFiles())
            {
                if (!String.Equals(x.Extension, ".stl", StringComparison.CurrentCultureIgnoreCase))
                    return;

                if (!r.Parse(Path.Combine(currDir, x.FullName)))
                    return;
            }
        }
    }
}
