﻿namespace Maple.MonoGameAssistant.Model
{
    public class MonoDescriptionMethodDTO : MonoDescriptionMemberDTO
    {
        public byte[]?[]? Utf8Parameters { get; set; }
        public byte[]? Utf8ReturnType { get; set; }
    }

}
