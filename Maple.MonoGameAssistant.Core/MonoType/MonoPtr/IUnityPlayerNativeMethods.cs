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

    }
}
