/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NetDataContractDeepCopy
{
    public class CustomDataType
    {
        private CustomEnum enumMember = CustomEnum.EnumVal1;
        private ExampleReferenceType referenceType = new ExampleReferenceType();

        public void RefreshReferenceType()
        {
            referenceType.Refresh();
        }

        private int intMember = 0;
        public int IntMember
        {
            get { return intMember; }
            set { intMember = value; }
        }

        private string stringMember = String.Empty;
        public string StringMember
        {
            get { return stringMember; }
            set { stringMember = value; }
        }

        private DateTime dateTimeMember = DateTime.MinValue;
        public DateTime DateTimeMember
        {
            get { return dateTimeMember; }
            set { dateTimeMember = value; }
        }

        public override string ToString()
        {
            return "IntMember: " + IntMember +
                ", DateTimeMember: " + DateTimeMember.ToString() +
                ", StringMember: " + stringMember + ", EnumMember: " +
                enumMember.ToString() +
                ", ReferenceType: " + referenceType.ToString();
        }

        public void SetEnumValue(CustomEnum enumValue)
        {
            enumMember = enumValue;
        }
    }

    public class ExampleReferenceType
    {
        private DateTime createdDate = DateTime.Now;

        public void Refresh()
        {
            createdDate = DateTime.Now;
        }

        public override string ToString()
        {
            return createdDate.ToString("HH:mm:ss.fff");
        }
    }

    public enum CustomEnum
    {
        EnumVal1 = 2,
        EnumVal2 = 4,
        EnumVal3 = 8,
        EnumVal4 = 16,
    }
}