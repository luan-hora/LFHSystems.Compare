using System.IO;

namespace LFHSystems.Compare.FolderComparison.Core
{
    public class FolderCompare
    {
        public FolderCompare(string path1, string path2, string pathToCopyTo)
        {
            this.Path1 = path1;
            this.Path2 = path2;
            this.PathToCopy = pathToCopyTo;
        }

        private string Path1 { get; }
        private string Path2 { get; set; }
        private string PathToCopy { get; set; }

        public bool CheckFileExistInBothFolders(FileInfo file, FileInfo fileCompare)
        {
            bool ret = true;
            if (file.Name == fileCompare.Name)
            {
                string pathToCopy = $"{this.PathToCopy}\\FileNotFound";
                string filePath = $"{Path1}\\{file.Name}";

                if (!Directory.Exists(pathToCopy))
                    Directory.CreateDirectory(pathToCopy);

                //if (File.Exists($"{pathToCopy}\\{file.Name}"))
                //    File.Delete($"{pathToCopy}\\{file.Name}");

                File.Copy(filePath, $"{pathToCopy}\\{file.Name}");

                ret = false;
            }

            return ret;
        }

        /// <summary>
        /// Check if both the last changed date and size of the file are the same, if not, copies it into anotherFolder
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileCompare"></param>
        public bool CompareFileSizeAndLastDate(FileInfo file, FileInfo fileCompare)
        {
            bool ret;
            if (ret = file.LastWriteTime != fileCompare.LastWriteTime && file.Length != fileCompare.Length)
            {
                string pathToCopy = $"{this.PathToCopy}\\DifferentSizeAndDate";
                string filePath = $"{Path1}\\{file.Name}";

                if (!Directory.Exists(pathToCopy))
                    Directory.CreateDirectory(pathToCopy);

                //if (File.Exists($"{pathToCopy}\\{file.Name}"))
                //    File.Delete($"{pathToCopy}\\{file.Name}");

                File.Copy(filePath, $"{pathToCopy}\\{file.Name}");
            }
            return ret;
        }

        /// <summary>
        /// Check if the last changed date of the files are different
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileCompare"></param>
        public bool CompareLastChangedDate(FileInfo file, FileInfo fileCompare)
        {
            bool ret;
            if (ret = file.LastWriteTime != fileCompare.LastWriteTime && file.Length == fileCompare.Length)
            {
                string pathToCopy = $"{this.PathToCopy}\\Date";
                string filePath = $"{Path1}\\{file.Name}";

                if (!Directory.Exists(pathToCopy))
                    Directory.CreateDirectory(pathToCopy);

                //if (File.Exists($"{pathToCopy}\\{file.Name}"))
                //    File.Delete($"{pathToCopy}\\{file.Name}");

                File.Copy(filePath, $"{pathToCopy}\\{file.Name}");
            }
            return ret;
        }

        /// <summary>
        /// Check if the last changed date of the files are different
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileCompare"></param>
        public bool CompareFileSize(FileInfo file, FileInfo fileCompare)
        {
            bool ret;
            if (ret = file.LastWriteTime == fileCompare.LastWriteTime && file.Length != fileCompare.Length)
            {
                string pathToCopy = $"{this.PathToCopy}\\Size";
                string filePath = $"{Path1}\\{file.Name}";

                if (!Directory.Exists(pathToCopy))
                    Directory.CreateDirectory(pathToCopy);

                //if (File.Exists($"{pathToCopy}\\{file.Name}"))
                //    File.Delete($"{pathToCopy}\\{file.Name}");

                File.Copy(filePath, $"{pathToCopy}\\{file.Name}");
            }
            return ret;
        }
    }
}
