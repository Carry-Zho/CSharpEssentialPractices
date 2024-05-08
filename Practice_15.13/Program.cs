namespace Practice_15._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"D:\Data\Data\Specialist KMS";
            IEnumerable<string> fileList = Directory.GetFiles(rootDirectory);
            foreach(var item in fileList) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************************************************");

            IEnumerable<FileInfo> files = fileList.Where(fileFullName => fileFullName.EndsWith(".png")).Select(file => new FileInfo(file));
            foreach (FileInfo file in files) 
            {
                Console.WriteLine($"{file.Name}, {file.CreationTime}, {file.Length}");
            }
        }
    }
}