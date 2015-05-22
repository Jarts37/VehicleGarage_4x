﻿
using System;

namespace VehicleGarage.DBCStructures
{
    public struct VehicleSeatEntry
    {
        public int Id;
        public VehicleSeatFlags Flags;
        public int AttachmentId;
        public float AttachmentOffsetX;
        public float AttachmentOffsetY;
        public float AttachmentOffsetZ;
        public float EnterPreDelay;
        public float EnterSpeed;
        public float EnterGravity;
        public float EnterMinDuration;
        public float EnterMaxDuration;
        public float EnterMinArcHeight;
        public float EnterMaxArcHeight;
        public int EnterAnimStart;
        public int EnterAnimLoop;
        public int RideAnimStart;
        public int RideAnimLoop;
        public int RideUpperAnimStart;
        public int RideUpperAnimLoop;
        public float ExitPreDelay;
        public float ExitSpeed;
        public float ExitGravity;
        public float ExitMinDuration;
        public float ExitMaxDuration;
        public float ExitMinArcHeight;
        public float ExitMaxArcHeight;
        public int ExitAnimStart;
        public int ExitAnimLoop;
        public int ExitAnimEnd;
        public float PassengerYaw;
        public float PassengerPitch;
        public float PassengerRoll;
        public int PassengerAttachmentId;
        public int VehicleEnterAnim;
        public int VehicleExitAnim;
        public int VehicleRideAnimLoop;
        public int VehicleEnterAnimBone;
        public int VehicleExitAnimBone;
        public int VehicleRideAnimLoopBone;
        public float VehicleEnterAnimDelay;
        public float VehicleExitAnimDelay;
        public int VehicleAbilityDisplay;
        public int EnterUiSoundId;
        public int ExitUiSoundId;
        public int Skin;
        public int FlagsB;
        public float CameraEnteringDelay;
        public float CameraEnteringDuration;
        public float CameraExitingDelay;  
        public float CameraExitingDuration;
        public float CameraOffsetX;  
        public float CameraOffsetY;  
        public float CameraOffsetZ;
        public float CameraPosChaseRate;  
        public float CameraFacingChaseRate;  
        public float CameraEnteringZoom; 
        public float CameraSeatZoomMin; 
        public float CameraSeatZoomMax;
        public int EnterAnimKitID;
        public int RideAnimKitID; 
        public int ExitAnimKitID;
        public int VehicleEnterAnimKitID; 
        public int VehicleRideAnimKitID; 
        public int VehicleExitAnimKitID; 
        public int CameraModeID;
        public int FlagsC; 
    }
}
