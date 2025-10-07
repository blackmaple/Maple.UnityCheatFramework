using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
#pragma warning disable IDE0060 // 删除未使用的参数

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator
{

    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
         class ClassPropertyMetadataAttribute : Attribute
    {
        public ClassPropertyMetadataAttribute(byte[]? utf8FieldName, byte[]? utf8FieldType = default)
        {

        }
        public ClassPropertyMetadataAttribute(string? fieldName, string? fieldType = default)
        {

        }

    }


    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
#if MetadataSourceGenerator
    internal
#else
    public
#endif
     class ClassPropertyCollectionAttribute : Attribute
    {

        public ClassPropertyCollectionAttribute(string? name = default, string? description = default)
        {

        }

    }

    public sealed class ClassPropertyContent
    {
        private const string DateTime_DefaultFormat = "yyyy/MM/dd HH:mm:ss";
        private const string Guid_DefaultFormat = "N";
        private const string IntPtr_DefaultFormat = "X8";

        public ClassPropertyContent(string key, string? name, string? desc, string? val)
        {
            this.Key = key;
            this.Name = name;
            this.Description = desc;
            this.Value = val;
        }
        public string Key { set; get; }
        public string? Name { get; }
        public string? Description { get; }
        public string? Value { get; }

        public static ClassPropertyContent Create(string key, string? name, string? desc, string? val)
        {
            return new ClassPropertyContent(key, name, desc, val);
        }

        public static ClassPropertyContent Create<T>(string key, string? name, string? desc, T val)
            where T : unmanaged
        {
            return new ClassPropertyContent(key, name, desc, val.ToString());
        }

        public static ClassPropertyContent Create(string key, string? name, string? desc, DateTime val)
        {
            return new ClassPropertyContent(key, name, desc, val.ToString(DateTime_DefaultFormat));
        }

        public static ClassPropertyContent Create(string key, string? name, string? desc, nint val)
        {
            return new ClassPropertyContent(key, name, desc, val.ToString(IntPtr_DefaultFormat));
        }

        public static ClassPropertyContent Create(string key, string? name, string? desc, Guid val)
        {
            return new ClassPropertyContent(key, name, desc, val.ToString(Guid_DefaultFormat));
        }


        // 基本值类型
        public static bool TryReadByte(string? str, out byte val)
        {
            return byte.TryParse(str, out val);
        }

        public static bool TryReadSByte(string? str, out sbyte val)
        {
            return sbyte.TryParse(str, out val);
        }

        public static bool TryReadShort(string? str, out short val)
        {
            return short.TryParse(str, out val);
        }

        public static bool TryReadUShort(string? str, out ushort val)
        {
            return ushort.TryParse(str, out val);
        }

        public static bool TryReadInt(string? str, out int val)
        {
            return int.TryParse(str, out val);
        }

        public static bool TryReadUInt(string? str, out uint val)
        {
            return uint.TryParse(str, out val);
        }

        public static bool TryReadLong(string? str, out long val)
        {
            return long.TryParse(str, out val);
        }

        public static bool TryReadULong(string? str, out ulong val)
        {
            return ulong.TryParse(str, out val);
        }

        public static bool TryReadFloat(string? str, out float val)
        {
            return float.TryParse(str, out val);
        }

        public static bool TryReadDouble(string? str, out double val)
        {
            return double.TryParse(str, out val);
        }

        public static bool TryReadDecimal(string? str, out decimal val)
        {
            return decimal.TryParse(str, out val);
        }

        public static bool TryReadBool(string? str, out bool val)
        {
            return bool.TryParse(str, out val);
        }

        public static bool TryReadChar(string? str, out char val)
        {
            return char.TryParse(str, out val);
        }

        public static bool TryReadDateTime(string? str, out DateTime val)
        {
            return DateTime.TryParseExact(str, DateTime_DefaultFormat, null, DateTimeStyles.None, out val); ;
        }

        public static bool TryReadGuid(string? str, out Guid val)
        {
            return Guid.TryParseExact(str, Guid_DefaultFormat, out val);
        }

        public static bool TryReadIntPtr(string? str, out nint val)
        {
#if MetadataSourceGenerator
                val = IntPtr.Zero;
                return false;
#else
            return IntPtr.TryParse(str, NumberStyles.HexNumber, null, out val);
#endif
        }



    }
}
#pragma warning restore IDE0060 // 删除未使用的参数
