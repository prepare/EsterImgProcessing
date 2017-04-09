/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace XMLDeserializationGenericExtension
{
    public static class ExtString
    {
        public static T DeserializeXML<T>(this string xmlString)
        {
            T returnValue = default(T);

            XmlSerializer serial = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xmlString);
            object result = serial.Deserialize(reader);

            if (result != null && result is T)
            {
                returnValue = ((T)result);
            }

            reader.Close();

            return returnValue;
        }
    }
}
