using Maple.MonoGameAssistant.MetadataModel.ClassMetadata;
using Maple.MonoGameAssistant.MetadataModel.Model;
using System.ComponentModel;
using System.IO;

namespace Maple.MonoGameAssistant.MetadataModel.ClassMetadata
{

    public interface IClassMetadataCollector
    {
        MonoMethodDelegate GetMethodDelegate(ulong code);
        nint GetMethodPointer(ulong code);

        MonoMemberFieldSource GetMemberFieldMetadata(ulong code);
        MonoStaticFieldSource GetStaticFieldMetadata(ulong code);

        int GetMemberFieldOffset(ulong code);
        nint GetStaticFieldValueAsPointer(ulong code);


    }
}
