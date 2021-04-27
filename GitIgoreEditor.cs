namespace gitignoreeditor
{
    public static  class GitIgoreEditor
    {
        public static void Replace(string location)
        {
            var inputStream= System.IO.File.ReadAllText(location);
            var lines = inputStream.Split("\n");
            var writeStream = "";
            int count = 1;
            foreach(var line in lines)
            {   
                var writeLine="";
                writeLine+=line;
                if(!(line.Length<1||line.StartsWith("#")||line.StartsWith("*/")||line.StartsWith(".git")||line[0]==13))
                {
                    writeLine = $"*/{writeLine}";
                }
                writeStream+=$"{writeLine}";
                if(count!=lines.Length)
                    writeLine += $"\n";
                ++count;
            }
            if(inputStream.Equals(writeStream))
            {
                System.Console.WriteLine("file is not changed");
                return;
            }
            System.IO.File.WriteAllText($"{location}_temp",inputStream);
            System.IO.File.WriteAllText(location,writeStream);
            System.Console.WriteLine($"Save file : {location}");
        }
    }
}