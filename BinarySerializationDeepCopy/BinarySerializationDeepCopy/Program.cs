/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySerializationDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDataType originalObject = new CustomDataType();
            originalObject.DateTimeMember = DateTime.Now;
            originalObject.IntMember = 42;
            originalObject.StringMember = "Some random string";

            CustomDataType deepCopyObject = originalObject.DeepCopy();
            deepCopyObject.DateTimeMember = DateTime.MinValue;
            deepCopyObject.IntMember = 123;
            deepCopyObject.StringMember = "Something else...";

            Console.WriteLine("originalObject: ");
            Console.WriteLine(originalObject.ToString());
            Console.WriteLine();

            Console.WriteLine("deepCopyObject: ");
            Console.WriteLine(deepCopyObject.ToString());
            Console.WriteLine();

            Console.WriteLine("Press any key...");
            Console.ReadKey();  
        }
    }
}
