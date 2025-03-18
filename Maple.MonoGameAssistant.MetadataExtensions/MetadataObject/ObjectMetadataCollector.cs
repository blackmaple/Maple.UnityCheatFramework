using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCommon;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
using Maple.MonoGameAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.MonoGameAssistant.MetadataExtensions.MetadataObject
{

    public readonly struct ObjectMetadataCollector(PMonoObject pMonoObject, MonoClassMetadataCollection metadataCollection)
    {
        PMonoObject MonoObject { get; } = pMonoObject;
        public MonoClassMetadataCollection MetadataCollection { get; } = metadataCollection;

        public readonly bool TryGetMemberFieldValue<T_FieldValue>(Func<MonoFieldInfoDTO, bool> predicate, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            Unsafe.SkipInit(out val);
            var search = this.MetadataCollection.EnumMemberFieldInfos().Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            val = ClassMetadataCollector.GetMemberFieldValue<T_FieldValue>(MonoObject, search.Offset);
            return true;
        }
        public readonly bool TryGetMemberFieldValue<T_FieldValue>(string fieldName, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TryGetMemberFieldValue(p => p.Name == fieldName, out val);
        }
        public readonly bool TryGetMemberFieldValue<T_FieldValue>(byte[] fieldName, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TryGetMemberFieldValue(p => MemoryExtensions.SequenceEqual(p.Utf8Name, fieldName), out val);
        }

        public readonly bool TrySetMemberFieldValue<T_FieldValue>(Func<MonoFieldInfoDTO, bool> predicate, in T_FieldValue val) where T_FieldValue : unmanaged
        {
            var search = this.MetadataCollection.EnumMemberFieldInfos().Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            ClassMetadataCollector.SetMemberFieldValue<T_FieldValue>(MonoObject, search.Offset, in val);
            return true;
        }
        public readonly bool TrySetMemberFieldValue<T_FieldValue>(string fieldName, in T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TrySetMemberFieldValue(p => p.Name == fieldName, in val);
        }
        public readonly bool TrySetMemberFieldValue<T_FieldValue>(byte[] fieldName, in T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TrySetMemberFieldValue(p => MemoryExtensions.SequenceEqual(p.Utf8Name, fieldName), in val);
        }

        public readonly bool TryGetStaticFieldValue<T_FieldValue>(Func<MonoFieldInfoDTO, bool> predicate, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            Unsafe.SkipInit(out val);
            var search = this.MetadataCollection.EnumStaticFieldInfos().Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            val = ClassMetadataCollector.GetStaticFieldValue<T_FieldValue>(new MonoStaticFieldSource(search.Pointer, search.SourceClass));
            return true;
        }
        public readonly bool TryGetStaticFieldValue<T_FieldValue>(string fieldName, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TryGetStaticFieldValue(p => p.Name == fieldName, out val);
        }
        public readonly bool TryGetStaticFieldValue<T_FieldValue>(byte[] fieldName, out T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TryGetStaticFieldValue(p => MemoryExtensions.SequenceEqual(p.Utf8Name, fieldName), out val);
        }

        public readonly bool TrySetStaticFieldValue<T_FieldValue>(Func<MonoFieldInfoDTO, bool> predicate, in T_FieldValue val) where T_FieldValue : unmanaged
        {

            var search = this.MetadataCollection.EnumStaticFieldInfos().Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            ClassMetadataCollector.SetStaticFieldValue<T_FieldValue>(new MonoStaticFieldSource(search.Pointer, search.SourceClass), val);
            return true;
        }
        public readonly bool TrySetStaticFieldValue<T_FieldValue>(string fieldName, in T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TrySetStaticFieldValue(p => p.Name == fieldName, in val);
        }
        public readonly bool TrySetStaticFieldValue<T_FieldValue>(byte[] fieldName, in T_FieldValue val) where T_FieldValue : unmanaged
        {
            return TrySetStaticFieldValue(p => MemoryExtensions.SequenceEqual(p.Utf8Name, fieldName), in val);
        }


        public readonly bool TryCallMemberMethod<T_FUNC>(Func<MonoMethodInfoDTO, bool> predicate, Action<T_FUNC> action) where T_FUNC : unmanaged
        {
            var search = this.MetadataCollection.MethodInfos.Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            if (!ClassMetadataCollector.TryGetMethodPointer<T_FUNC>(search, out var method))
            {
                return false;
            }
            action.Invoke(method);
            return true;
        }
        public readonly bool TryCallMemberMethod<T_FUNC, T_ARGS>(Func<MonoMethodInfoDTO, bool> predicate, Action<T_FUNC, T_ARGS> action, in T_ARGS args)
            where T_FUNC : unmanaged
            where T_ARGS : unmanaged
        {
            var search = this.MetadataCollection.MethodInfos.Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            if (!ClassMetadataCollector.TryGetMethodPointer<T_FUNC>(search, out var method))
            {
                return false;
            }
            action.Invoke(method, args);
            return true;
        }

        public readonly bool TryCallMemberMethod<T_FUNC, T_RETURN>(Func<MonoMethodInfoDTO, bool> predicate, Func<T_FUNC, T_RETURN> func, out T_RETURN ret)
            where T_FUNC : unmanaged
            where T_RETURN : unmanaged
        {
            Unsafe.SkipInit(out ret);
            var search = this.MetadataCollection.MethodInfos.Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            if (!ClassMetadataCollector.TryGetMethodPointer<T_FUNC>(search, out var method))
            {
                return false;
            }
            ret = func.Invoke(method);
            return true;
        }
        public readonly bool TryCallMemberMethod<T_FUNC, T_ARGS, T_RETURN>(Func<MonoMethodInfoDTO, bool> predicate, Func<T_FUNC, T_ARGS, T_RETURN> func, in T_ARGS args, out T_RETURN ret)
            where T_FUNC : unmanaged
            where T_RETURN : unmanaged
        {
            Unsafe.SkipInit(out ret);
            var search = this.MetadataCollection.MethodInfos.Where(predicate).FirstOrDefault();
            if (search is null)
            {
                return false;
            }
            if (!ClassMetadataCollector.TryGetMethodPointer<T_FUNC>(search, out var method))
            {
                return false;
            }
            ret = func.Invoke(method, args);
            return true;
        }

    }

}
