using System;

namespace Maple.MonoGameAssistant.MetadataModel.MetadataAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SettingsMetadataAttribute(ulong code) : Attribute
    {
        public ulong Code { get; } = code;
        public bool RandomSalt { set; get; } = false;
    }
}
