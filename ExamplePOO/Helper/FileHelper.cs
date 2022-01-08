namespace ExamplePOO.Helper
{
    public class FileHelper
    {
        public void ListDirectories(string path)
        {
            var returnPath = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var r in returnPath)
            {
                System.Console.WriteLine(r);
            }
        }

        public void ListFilesInFolder(string path)
        {
            var returnFilesPath = Directory.GetFiles(path, "*1*", SearchOption.AllDirectories);
            foreach (var r in returnFilesPath)
            {
                System.Console.WriteLine(r);
            }

        }

        public void CreateDirectory(string path)
        {
            var returnDirectory = Directory.CreateDirectory(path);
            System.Console.WriteLine(returnDirectory.FullName);

        }

        public void deleteDirectory(string path, Boolean deleteFiles)
        {
            Directory.Delete(path, deleteFiles);
        }

        public void CreateTxtFile(string path, string content)
        {
            if (!File.Exists(path)) File.WriteAllText(path, content);
        }

        public void CreateTxtFileStream(string path, List<string> content)
        {
            using (var stream = File.CreateText(path))
            {
                foreach (var line in content)
                {
                    stream.WriteLine(line);
                }
            }

        }

        public void AddTextInFile(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public void AddTextInFileStream(string path, List<string> content)
        {
            using (var stream = File.AppendText(path))
            {
                foreach (var line in content)
                {
                    stream.WriteLine(line);
                }
            }

        }

        public void ReadFile(string path)
        {
            string[] returnLines = File.ReadAllLines(path);

            foreach (var item in returnLines)
            {
                System.Console.WriteLine(item);
            }
        }

        public void ReadFileSteam(string path)
        {
            string line = string.Empty;

            using (var steam = File.OpenText(path))
            {
                while ((line = steam.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }

        public void MoveFile(string path, string newPath, bool overwrite)
        {
            File.Move(path, newPath, overwrite);
        }

        public void CopyFile(string path, string newPath, bool overwrite)
        {
            File.Copy(path, newPath, overwrite);
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}