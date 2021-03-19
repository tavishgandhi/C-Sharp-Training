using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Day4A3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("File Operations");
            string path = @"C:\Users\tavishgandhi\Desktop\NagarroAssignments\Temporary_Foleder_For_Day4Assignment";

            FileHelper fileHelper = new FileHelper(path);

            //1. All the files in the given directory
            List<FileInfo> FileNames = new List<FileInfo>();
            Console.WriteLine("All the files in the given directory:");

            // Adding names of all the files in directory to list
            var list = from file in new DirectoryInfo(path).GetFiles()
                        select file;
            foreach (var file in list)
            {
                FileNames.Add(file);
                //Console.WriteLine(file.Name + " " + file.Length);
            }
           
            // 1. Number of text files present (*.txt).
            int textFilesCount = fileHelper.TextFilesCount(FileNames);
            Console.WriteLine($"The number of Text files(.txt) in given directory: {textFilesCount}");

            //2. Number of files per Extension type
            fileHelper.ExtensionFiles(FileNames);
            
            //3. Name and size of top 5 files
            Console.WriteLine("Top 5 largest directory are :-");
            fileHelper.LargestFiles(FileNames);

            //4. File with the Maximum Length.
            Console.WriteLine("The maximum length file is: ");
            fileHelper.MaximumLength(FileNames);
            
        }
        
    }
}

