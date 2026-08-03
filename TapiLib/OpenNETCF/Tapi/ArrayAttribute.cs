namespace OpenNETCF.Tapi
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    internal class ArrayAttribute : Attribute
    {
        public int Size;

        public ArrayAttribute(int size)
        {
            this.Size = size;
        }
    }
}

