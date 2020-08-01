namespace TextFilter
{
    public class FileReader
    {
        public string Read(string filePath)
        {
            return System.IO.File.ReadAllText(filePath);
        }
    }
}