using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A3Q1
{
    class FileHelper
    {
        public string path { get; set; }
        public FileHelper(string path)
        {
            this.path = path;
        }

        // Maximum length file out of given list of files
        public void MaximumLength(List<FileInfo> fileNames)
        {
            var query = fileNames.OrderByDescending(file => file.Length).Take(1);
            foreach (var file in query) Console.WriteLine(file.Name);
        }

        // Largest File out of given list of files
        public void LargestFiles(List<FileInfo> fileNames)
        {
            var files = fileNames.OrderByDescending(file => file.Length)
                .Take(5);
            foreach (var file in files)
            {
                Console.WriteLine($"File : {file.Name}. \n" +
                    $"Length : {file.Length}");
            }
        }

        // Extensions and corresponding files
        public void ExtensionFiles(List<FileInfo> fileNames)
        {
            var extensionFileAndCount = fileNames.Select(file => Path.GetExtension(file.Name).TrimStart('.').ToUpper())
                .GroupBy(x => x, (extension, extCount) => new
                {
                    Extension = extension,
                    Count = extCount.Count()
                });
            foreach (var file in extensionFileAndCount)
            {
                Console.WriteLine($"File Extension : {file.Extension}. \nCount : {file.Count}");
            }
        }

        // Text Files out of given files.
        public int TextFilesCount(List<FileInfo> fileNames)
        {
            int count = (fileNames.Where(file => file.Name.EndsWith(".txt"))
                        .Select(file => file).ToList()).Count();
            return count;
        }
    }
}
