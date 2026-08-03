namespace OpenNETCF.Tapi
{
    using System;
    using System.Reflection;

    public class TapiStruct
    {
        [Internal]
        private byte[] m_data;

        public TapiStruct(int nSize)
        {
            this.m_data = new byte[nSize];
            this.InitStructs(this);
        }

        protected object InitStructs(object obj)
        {
            foreach (FieldInfo info in obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                Type fieldType = info.FieldType;
                if (fieldType.IsArray)
                {
                    object[] customAttributes = info.GetCustomAttributes(typeof(ArrayAttribute), true);
                    if (customAttributes.Length != 1)
                    {
                        throw new NotSupportedException(string.Format("Field {0}: Must have Array attribute with size specified", info.Name));
                    }
                    int size = (customAttributes[0] as ArrayAttribute).Size;
                    info.SetValue(obj, Array.CreateInstance(info.FieldType.GetElementType(), size));
                }
                else if (fieldType.IsValueType && !fieldType.IsPrimitive)
                {
                    info.SetValue(obj, this.InitStructs(info.GetValue(obj)));
                }
            }
            return obj;
        }

        public void Load()
        {
            ByteCopy.ByteArrayToStruct(this.m_data, this);
        }

        public void Store()
        {
            ByteCopy.StructToByteArray(this, this.m_data);
        }

        public byte[] Data
        {
            get
            {
                return this.m_data;
            }
            set
            {
                this.m_data = value;
            }
        }
    }
}

