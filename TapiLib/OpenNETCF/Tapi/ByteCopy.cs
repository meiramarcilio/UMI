namespace OpenNETCF.Tapi
{
    using System;
    using System.Reflection;

    public class ByteCopy
    {
        public static void ByteArrayToStruct(byte[] data, object target)
        {
            int index = 0;
            ByteArrayToStruct(data, ref index, target);
        }

        private static void ByteArrayToStruct(byte[] data, ref int index, object target)
        {
            int sourceIndex = index;
            foreach (FieldInfo info in target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                Type fieldType = info.FieldType;
                if (fieldType.GetCustomAttributes(typeof(InternalAttribute), false).Length <= 0)
                {
                    if (fieldType.IsArray)
                    {
                        if (fieldType.GetElementType() != typeof(byte))
                        {
                            throw new NotSupportedException(string.Format("Field {0}: Only byte arrays are supported", info.Name));
                        }
                        object[] customAttributes = info.GetCustomAttributes(typeof(ArrayAttribute), true);
                        if (customAttributes.Length != 1)
                        {
                            throw new NotSupportedException(string.Format("Field {0}: Must have Array attribute with size specified", info.Name));
                        }
                        int size = (customAttributes[0] as ArrayAttribute).Size;
                        byte[] destinationArray = new byte[size];
                        Array.Copy(data, sourceIndex, destinationArray, 0, size);
                        info.SetValue(target, destinationArray);
                        sourceIndex += size;
                    }
                    else if ((fieldType == typeof(byte)) || (fieldType == typeof(sbyte)))
                    {
                        info.SetValue(target, data[sourceIndex++]);
                    }
                    else if (fieldType == typeof(short))
                    {
                        info.SetValue(target, BitConverter.ToInt16(data, sourceIndex));
                        sourceIndex += 2;
                    }
                    else if (fieldType == typeof(ushort))
                    {
                        info.SetValue(target, BitConverter.ToUInt16(data, sourceIndex));
                        sourceIndex += 2;
                    }
                    else if (fieldType == typeof(int))
                    {
                        info.SetValue(target, BitConverter.ToInt32(data, sourceIndex));
                        sourceIndex += 4;
                    }
                    else if (fieldType == typeof(uint))
                    {
                        info.SetValue(target, BitConverter.ToUInt32(data, sourceIndex));
                        sourceIndex += 4;
                    }
                    else if (fieldType == typeof(IntPtr))
                    {
                        info.SetValue(target, (IntPtr) BitConverter.ToInt32(data, sourceIndex));
                        sourceIndex += 4;
                    }
                    else if (fieldType == typeof(UIntPtr))
                    {
                        info.SetValue(target, (UIntPtr) BitConverter.ToUInt32(data, sourceIndex));
                        sourceIndex += 4;
                    }
                    else if (fieldType.IsValueType && (fieldType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Length > 0))
                    {
                        object obj2 = Activator.CreateInstance(fieldType);
                        ByteArrayToStruct(data, ref sourceIndex, obj2);
                        info.SetValue(target, obj2);
                    }
                }
            }
            index = sourceIndex;
        }

        public static void StructToByteArray(object source, byte[] data)
        {
            int index = 0;
            StructToByteArray(source, ref index, data);
        }

        public static void StructToByteArray(object source, ref int index, byte[] data)
        {
            int destinationIndex = index;
            foreach (FieldInfo info in source.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                Type fieldType = info.FieldType;
                if (fieldType.GetCustomAttributes(typeof(InternalAttribute), false).Length <= 0)
                {
                    if (fieldType.IsArray)
                    {
                        if (fieldType.GetElementType() != typeof(byte))
                        {
                            throw new NotSupportedException(string.Format("Field {0}: Only byte arrays are supported", info.Name));
                        }
                        object[] customAttributes = info.GetCustomAttributes(typeof(ArrayAttribute), true);
                        if (customAttributes.Length != 1)
                        {
                            throw new NotSupportedException(string.Format("Field {0}: Must have Array attribute with size specified", info.Name));
                        }
                        int size = (customAttributes[0] as ArrayAttribute).Size;
                        byte[] sourceArray = (byte[]) info.GetValue(source);
                        Array.Copy(sourceArray, 0, data, destinationIndex, Math.Min(size, sourceArray.Length));
                        destinationIndex += Math.Min(size, sourceArray.Length);
                    }
                    else if (fieldType == typeof(byte))
                    {
                        data[destinationIndex++] = (byte) info.GetValue(source);
                    }
                    else if (fieldType == typeof(sbyte))
                    {
                        data[destinationIndex++] = (byte) info.GetValue(source);
                    }
                    else if (fieldType == typeof(short))
                    {
                        BitConverter.GetBytes((short) info.GetValue(source)).CopyTo(data, destinationIndex);
                        destinationIndex += 2;
                    }
                    else if (fieldType == typeof(ushort))
                    {
                        BitConverter.GetBytes((ushort) info.GetValue(source)).CopyTo(data, destinationIndex);
                        destinationIndex += 2;
                    }
                    else if (fieldType == typeof(int))
                    {
                        BitConverter.GetBytes((int) info.GetValue(source)).CopyTo(data, destinationIndex);
                        destinationIndex += 4;
                    }
                    else if (fieldType == typeof(uint))
                    {
                        BitConverter.GetBytes((uint) info.GetValue(source)).CopyTo(data, destinationIndex);
                        destinationIndex += 4;
                    }
                    else if (fieldType == typeof(IntPtr))
                    {
                        IntPtr ptr = (IntPtr) info.GetValue(source);
                        BitConverter.GetBytes(ptr.ToInt32()).CopyTo(data, destinationIndex);
                        destinationIndex += 4;
                    }
                    else if (fieldType == typeof(UIntPtr))
                    {
                        UIntPtr ptr2 = (UIntPtr) info.GetValue(source);
                        BitConverter.GetBytes(ptr2.ToUInt32()).CopyTo(data, destinationIndex);
                        destinationIndex += 4;
                    }
                    else if (fieldType.IsValueType && (fieldType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Length > 0))
                    {
                        StructToByteArray(info.GetValue(source), ref destinationIndex, data);
                    }
                }
            }
            index = destinationIndex;
        }
    }
}

