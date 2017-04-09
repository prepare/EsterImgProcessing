/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadOnlyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating new file...");
            StreamWriter streamWriter = File.CreateText("ReadOnlyFile.txt");
            streamWriter.WriteLine("This is a code sample from http://softwarebydefault.com");
            streamWriter.Close();
            Console.WriteLine("File Created.");

            FileInfo fileInfo = new FileInfo("ReadOnlyFile.txt");
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to set read only: method 1");
            fileInfo.IsReadOnly = true;
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to undo read only: method 1");
            fileInfo.IsReadOnly = false;
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to set read only: method 2");
            File.SetAttributes("ReadOnlyFile.txt", FileAttributes.ReadOnly);
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to undo read only method 2");
            File.SetAttributes("ReadOnlyFile.txt", ~FileAttributes.ReadOnly);
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to set read only: method 3");
            fileInfo.Attributes = fileInfo.Attributes | FileAttributes.ReadOnly;
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Attempting to undo read only: method 3");
            fileInfo.Attributes = fileInfo.Attributes & ~FileAttributes.ReadOnly;
            DisplayFileStatus(fileInfo);
            Console.WriteLine();

            Console.WriteLine("Press any key...");
            Console.ReadKey();

            File.Delete("ReadOnlyFile.txt");
        }

        private static void DisplayFileStatus(FileInfo fileInfo)
        {
            fileInfo.Refresh();

            Console.WriteLine("File read only: " +
                (fileInfo.IsReadOnly ? "Yes" : "No"));
        }
    }
}
