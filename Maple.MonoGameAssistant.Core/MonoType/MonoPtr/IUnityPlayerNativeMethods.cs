namespace Maple.MonoGameAssistant.Core
{
    public interface IUnityPlayerNativeMethods : IMonoMetadataCollector
    {
        public enum ReadSpriteType
        {
            TYPE1 = 1,
            TYPE2 = 2,
            TYPE3 = 3,
        }
        PMonoArray<byte> ReadSprite2Png(nint ptr_Sprite, ReadSpriteType type = ReadSpriteType.TYPE2);
        void SetImeCompositionMode() => throw new NotImplementedException();

        bool TryGetTextureInfo(nint ptr_Sprite, out nint native_ptr, out float u0, out float v0, out float u1, out float v1)
            => throw new NotImplementedException();

    }
}
