namespace gitignoreeditor
{
    public static  class GitIgoreEditor
    {
        public static void Replace(string location)
        {
            var inputStream= System.IO.File.ReadAllText(location);
            var lines = inputStream.Split("\n");
            var writeStream = "";
            foreach(var line in lines)
            {
                var writeLine = line;
                if(!(line.StartsWith("#")||line.StartsWith("*/")||line.StartsWith(".git")||line[0]==13))
                {
                    writeLine = $"*/{writeLine}";
                }
                writeStream+=$"{writeLine}\n";
            }
            System.IO.File.WriteAllText($"{location}_temp",inputStream);
            System.IO.File.WriteAllText(location,writeStream);
        }
    }
}