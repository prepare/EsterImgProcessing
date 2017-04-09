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
using System.Diagnostics;

namespace DriveSpaceAvailable
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Environment.CurrentDirectory != String.Empty)
            {
                string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);

                DriveInfo drive = new DriveInfo(driveLetter);

                Console.WriteLine("TotalFreeSpace: {0,0:F3} B",
                drive.TotalFreeSpace);

                Console.WriteLine();
                Console.WriteLine("TotalFreeSpaceFormatted:");

                Console.WriteLine("{0,0:F3} B",
                drive.TotalFreeSpaceFormatted(DiskSizeUnit.Bytes));

                Console.WriteLine("{0,0:F3} KB",
                drive.TotalFreeSpaceFormatted(DiskSizeUnit.KiloBytes));

                Console.WriteLine("{0,0:F3} MB",
                drive.TotalFreeSpaceFormatted(DiskSizeUnit.MegaBytes));

                Console.WriteLine("{0,0:F3} GB",
                drive.TotalFreeSpaceFormatted(DiskSizeUnit.GigaBytes));

                Console.WriteLine("{0,0:F3} TB",
                drive.TotalFreeSpaceFormatted(DiskSizeUnit.TeraBytes));

                Console.WriteLine();

                Console.WriteLine("TotalFreeSpace: {0,0:F3} B",
               drive.AvailableFreeSpace);

                Console.WriteLine();
                Console.WriteLine("AvailableFreeSpaceFormatted:");

                Console.WriteLine("{0,0:F3} B",
                drive.AvailableFreeSpaceFormatted(DiskSizeUnit.Bytes));

                Console.WriteLine("{0,0:F3} KB",
                drive.AvailableFreeSpaceFormatted(DiskSizeUnit.KiloBytes));

                Console.WriteLine("{0,0:F3} MB",
                drive.AvailableFreeSpaceFormatted(DiskSizeUnit.MegaBytes));

                Console.WriteLine("{0,0:F3} GB",
                drive.AvailableFreeSpaceFormatted(DiskSizeUnit.GigaBytes));

                Console.WriteLine("{0,0:F3} TB",
                drive.AvailableFreeSpaceFormatted(DiskSizeUnit.TeraBytes));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
