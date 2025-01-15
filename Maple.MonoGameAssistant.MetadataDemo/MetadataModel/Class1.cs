//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Maple.MonoGameAssistant.MetadataDemo.MetadataModel
//{
//    partial class Main : Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.Ptr_Main>
//    {
//        public static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonClassDTO MonoJsonClassDTO { get; } = new Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonClassDTO(13054UL, [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112], [71, 97, 109, 101, 77, 97, 105, 110], [77, 97, 105, 110], [71, 97, 109, 101, 77, 97, 105, 110, 46, 77, 97, 105, 110]);
//        public static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonFieldDTO[] MonoJsonFieldDTO { get; } = new Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonFieldDTO[]
//        {
//            new Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonFieldDTO(14154UL, [60, 71, 97, 109, 101, 62, 107, 95, 95, 66, 97, 99, 107, 105, 110, 103, 70, 105, 101, 108, 100], [71, 97, 109, 101, 77, 97, 105, 110, 46, 71, 97, 109, 101], false),
//            new Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonFieldDTO(13604UL, [105, 110, 115, 116], [71, 97, 109, 101, 77, 97, 105, 110, 46, 77, 97, 105, 110], true)
//        };
//        public static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonMethodDTO[] MonoJsonMethodDTO { get; } = new Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoJsonMethodDTO[]
//        {
//        };

//        static int s_Field_GAME;
//        static Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.MonoStaticFieldSource s_Field_INST;
//        public Main(Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ContextMetadataCollector metadataCollector, ulong code = 13054UL) : base(metadataCollector, code)
//        {
//            Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.s_Field_GAME = this.GetMemberFieldOffset(14154UL);
//            Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.s_Field_INST = this.GetStaticFieldMetadata(13604UL);
//        }

//        partial struct Ptr_Main
//        {
//            public partial Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Game.Ptr_Game GAME
//            {
//                get
//                {
//                    return Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.GetMemberFieldValue<Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Game.Ptr_Game>(this, Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.s_Field_GAME);
//                }
//            }

//            public static partial nint INST
//            {
//                get
//                {
//                    return Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.GetStaticFieldValue<nint>(Maple.MonoGameAssistant.MetadataDemo.MetadataModel.Main.s_Field_INST);
//                }
//            }
//        }
//    }

//}
