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

namespace DriveSpaceAvailable
{
    public static class ExtDriveInfo
    {
        public static double TotalFreeSpaceFormatted(this DriveInfo driveInfo, DiskSizeUnit sizeUnit)
        {
            double freeSpace = -1;
            double formatDivideBy = 1;

            if (driveInfo != null)
            {
                long freeSpaceNative = driveInfo.TotalFreeSpace;
                formatDivideBy = Math.Pow(1024, (int)sizeUnit);

                freeSpace = freeSpaceNative / formatDivideBy;
            }

            return freeSpace;
        }

        public static double AvailableFreeSpaceFormatted(this DriveInfo driveInfo, DiskSizeUnit sizeUnit)
        {
            double freeSpace = -1;
            double formatDivideBy = 1;

            if (driveInfo != null)
            {
                long freeSpaceNative = driveInfo.AvailableFreeSpace;
                formatDivideBy = Math.Pow(1024, (int)sizeUnit);

                freeSpace = freeSpaceNative / formatDivideBy;
            }

            return freeSpace;
        }
    }

    public enum DiskSizeUnit
    {
        Bytes = 0,
        KiloBytes = 1,
        MegaBytes = 2,
        GigaBytes = 3,
        TeraBytes = 4
    }
}
