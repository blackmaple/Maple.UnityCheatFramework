﻿namespace Maple.MonoGameAssistant.MetadataDemo
{
    public partial class EsportsGameEnv
    {

        public MetadataModel.Main.Ptr_Main PtrMain { get; }
        public MetadataModel.Game.Ptr_Game PtrGame { get; }
        public MetadataModel.Club.Ptr_Club PtrClub => this.PtrGame.C_CLUB_PLAYER;

        public MetadataModel.DataComponent.Ptr_DataComponent Ptr_DataComponent => PtrClub.C_DATA;
        public MetadataModel.ClubAthleteData.Ptr_ClubAthleteData Ptr_ClubAthleteData => Ptr_DataComponent.C_ATHLETE_DATA;

        public EsportsGameEnv()
        {

            this.PtrMain = MetadataModel.Main.Ptr_Main.C_INST;
            this.PtrGame = PtrMain.GAME;
        }


        //public bool ThrowNotLoadGame()
        //{

        //    if (this.PtrGame)
        //    {
        //        return true;
        //    }
        //    return Maple.MonoGameAssistant.GameDTO.GameException.ThrowIfNotLoaded<bool>();

        //}


    }

}
