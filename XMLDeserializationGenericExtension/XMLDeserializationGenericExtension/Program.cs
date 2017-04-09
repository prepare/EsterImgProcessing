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

namespace XMLDeserializationGenericExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("CustomDataType.xml") == true)
            {
                string xmlString = File.ReadAllText("CustomDataType.xml");
                CustomDataType objectData = xmlString.DeserializeXML<CustomDataType>();

                Console.WriteLine("CustomDataType.DateTimeMember: " + objectData.DateTimeMember);
                Console.WriteLine("CustomDataType.IntMember: " + objectData.IntMember.ToString());
                Console.WriteLine("CustomDataType.StringMember: " + objectData.StringMember);

                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
