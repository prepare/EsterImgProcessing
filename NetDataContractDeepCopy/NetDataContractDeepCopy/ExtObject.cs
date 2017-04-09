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
using System.Runtime.Serialization;

namespace NetDataContractDeepCopy
{
    public static class ExtObject
    {
        public static T DeepCopy<T>(this T objectToCopy)
        {   
            MemoryStream memoryStream = new MemoryStream();
            NetDataContractSerializer netFormatter = new NetDataContractSerializer();

            netFormatter.Serialize(memoryStream, objectToCopy);

            memoryStream.Position = 0;
            T returnValue = (T)netFormatter.Deserialize(memoryStream);

            memoryStream.Close();
            memoryStream.Dispose();

            return returnValue;
        }
    }
}
