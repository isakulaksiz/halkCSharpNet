namespace Constructor
{
    public class ReportGenerator
    {
        public string FilePath { get; set; }
        public ReportGenerator(string filePath)
        {
            FilePath = filePath;
        }
    }
}
