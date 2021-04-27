using System;

namespace gitignoreeditor
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >1){
                System.Console.WriteLine("Input only .gitignore file location");
                return;
            }
            GitIgoreEditor.Replace(args[0]);
        }
    }
}
