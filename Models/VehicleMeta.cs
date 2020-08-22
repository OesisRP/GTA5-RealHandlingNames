using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GTA5_RealHandlingNames
{
    public partial class VehiclesMeta
    {
        [JsonProperty("?xml")]
        public Xml Xml { get; set; }

        [JsonProperty("CVehicleModelInfo__InitDataList")]
        public CVehicleModelInfoInitDataList CVehicleModelInfoInitDataList { get; set; }
    }

    public partial class CVehicleModelInfoInitDataList
    {
        [JsonProperty("residentTxd")]
        public string ResidentTxd { get; set; }

        [JsonProperty("residentAnims")]
        public object ResidentAnims { get; set; }

        [JsonProperty("InitDatas")]
        public InitDatas InitDatas { get; set; }

        [JsonProperty("txdRelationships")]
        public TxdRelationships TxdRelationships { get; set; }
    }

    public partial class InitDatas
    {
        [JsonProperty("Item")]
        public List<InitDatasItem> Item { get; set; }
    }

    public partial class InitDatasItem
    {
        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("txdName")]
        public string TxdName { get; set; }

        [JsonProperty("handlingId")]
        public string HandlingId { get; set; }

        [JsonProperty("gameName")]
        public string GameName { get; set; }

        [JsonProperty("vehicleMakeName")]
        public string VehicleMakeName { get; set; }

        [JsonProperty("expressionDictName")]
        public Name ExpressionDictName { get; set; }

        [JsonProperty("expressionName")]
        public Name ExpressionName { get; set; }

        [JsonProperty("animConvRoofDictName")]
        public Name AnimConvRoofDictName { get; set; }

        [JsonProperty("animConvRoofName")]
        public Name AnimConvRoofName { get; set; }

        [JsonProperty("animConvRoofWindowsAffected")]
        public object AnimConvRoofWindowsAffected { get; set; }

        [JsonProperty("ptfxAssetName")]
        public Name PtfxAssetName { get; set; }

        [JsonProperty("audioNameHash")]
        public object AudioNameHash { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("coverBoundOffsets")]
        public string CoverBoundOffsets { get; set; }

        [JsonProperty("explosionInfo")]
        public ExplosionInfo ExplosionInfo { get; set; }

        [JsonProperty("scenarioLayout")]
        public object ScenarioLayout { get; set; }

        [JsonProperty("cameraName")]
        public string CameraName { get; set; }

        [JsonProperty("aimCameraName")]
        public string AimCameraName { get; set; }

        [JsonProperty("bonnetCameraName")]
        public string BonnetCameraName { get; set; }

        [JsonProperty("povCameraName")]
        public string PovCameraName { get; set; }

        [JsonProperty("FirstPersonDriveByIKOffset")]
        public Offset FirstPersonDriveByIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByUnarmedIKOffset")]
        public Offset FirstPersonDriveByUnarmedIkOffset { get; set; }

        [JsonProperty("FirstPersonProjectileDriveByIKOffset")]
        public dynamic FirstPersonProjectileDriveByIkOffset { get; set; }

        [JsonProperty("FirstPersonProjectileDriveByPassengerIKOffset")]
        public Offset FirstPersonProjectileDriveByPassengerIkOffset { get; set; }

        [JsonProperty("FirstPersonProjectileDriveByRearLeftIKOffset", NullValueHandling = NullValueHandling.Ignore)]
        public Offset FirstPersonProjectileDriveByRearLeftIkOffset { get; set; }

        [JsonProperty("FirstPersonProjectileDriveByRearRightIKOffset", NullValueHandling = NullValueHandling.Ignore)]
        public Offset FirstPersonProjectileDriveByRearRightIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByLeftPassengerIKOffset")]
        public Offset FirstPersonDriveByLeftPassengerIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByRightPassengerIKOffset")]
        public Offset FirstPersonDriveByRightPassengerIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByRightRearPassengerIKOffset", NullValueHandling = NullValueHandling.Ignore)]
        public Offset FirstPersonDriveByRightRearPassengerIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByLeftPassengerUnarmedIKOffset")]
        public Offset FirstPersonDriveByLeftPassengerUnarmedIkOffset { get; set; }

        [JsonProperty("FirstPersonDriveByRightPassengerUnarmedIKOffset")]
        public dynamic FirstPersonDriveByRightPassengerUnarmedIkOffset { get; set; }

        [JsonProperty("FirstPersonMobilePhoneOffset")]
        public Offset FirstPersonMobilePhoneOffset { get; set; }

        [JsonProperty("FirstPersonPassengerMobilePhoneOffset")]
        public Offset FirstPersonPassengerMobilePhoneOffset { get; set; }

        [JsonProperty("PovCameraOffset")]
        public Offset PovCameraOffset { get; set; }

        [JsonProperty("PovCameraVerticalAdjustmentForRollCage")]
        public TartuGecko PovCameraVerticalAdjustmentForRollCage { get; set; }

        [JsonProperty("PovPassengerCameraOffset")]
        public Offset PovPassengerCameraOffset { get; set; }

        [JsonProperty("PovRearPassengerCameraOffset", NullValueHandling = NullValueHandling.Ignore)]
        public Offset PovRearPassengerCameraOffset { get; set; }

        [JsonProperty("vfxInfoName")]
        public dynamic VfxInfoName { get; set; }

        [JsonProperty("shouldUseCinematicViewMode")]
        public TartuGecko ShouldUseCinematicViewMode { get; set; }

        [JsonProperty("shouldCameraTransitionOnClimbUpDown")]
        public TartuGecko ShouldCameraTransitionOnClimbUpDown { get; set; }

        [JsonProperty("shouldCameraIgnoreExiting")]
        public TartuGecko ShouldCameraIgnoreExiting { get; set; }

        [JsonProperty("AllowPretendOccupants")]
        public TartuGecko AllowPretendOccupants { get; set; }

        [JsonProperty("AllowJoyriding")]
        public TartuGecko AllowJoyriding { get; set; }

        [JsonProperty("AllowSundayDriving")]
        public TartuGecko AllowSundayDriving { get; set; }

        [JsonProperty("AllowBodyColorMapping")]
        public TartuGecko AllowBodyColorMapping { get; set; }

        [JsonProperty("wheelScale")]
        public TartuGecko WheelScale { get; set; }

        [JsonProperty("wheelScaleRear")]
        public TartuGecko WheelScaleRear { get; set; }

        [JsonProperty("dirtLevelMin")]
        public TartuGecko DirtLevelMin { get; set; }

        [JsonProperty("dirtLevelMax")]
        public TartuGecko DirtLevelMax { get; set; }

        [JsonProperty("envEffScaleMin")]
        public TartuGecko EnvEffScaleMin { get; set; }

        [JsonProperty("envEffScaleMax")]
        public TartuGecko EnvEffScaleMax { get; set; }

        [JsonProperty("envEffScaleMin2")]
        public TartuGecko EnvEffScaleMin2 { get; set; }

        [JsonProperty("envEffScaleMax2")]
        public TartuGecko EnvEffScaleMax2 { get; set; }

        [JsonProperty("damageMapScale")]
        public TartuGecko DamageMapScale { get; set; }

        [JsonProperty("damageOffsetScale")]
        public TartuGecko DamageOffsetScale { get; set; }

        [JsonProperty("diffuseTint")]
        public TartuGecko DiffuseTint { get; set; }

        [JsonProperty("steerWheelMult")]
        public TartuGecko SteerWheelMult { get; set; }

        [JsonProperty("HDTextureDist")]
        public TartuGecko HdTextureDist { get; set; }

        [JsonProperty("lodDistances")]
        public LodDistances LodDistances { get; set; }

        [JsonProperty("minSeatHeight", NullValueHandling = NullValueHandling.Ignore)]
        public TartuGecko MinSeatHeight { get; set; }

        [JsonProperty("identicalModelSpawnDistance")]
        public TartuGecko IdenticalModelSpawnDistance { get; set; }

        [JsonProperty("maxNumOfSameColor")]
        public TartuGecko MaxNumOfSameColor { get; set; }

        [JsonProperty("defaultBodyHealth")]
        public TartuGecko DefaultBodyHealth { get; set; }

        [JsonProperty("pretendOccupantsScale")]
        public TartuGecko PretendOccupantsScale { get; set; }

        [JsonProperty("visibleSpawnDistScale")]
        public TartuGecko VisibleSpawnDistScale { get; set; }

        [JsonProperty("trackerPathWidth")]
        public TartuGecko TrackerPathWidth { get; set; }

        [JsonProperty("weaponForceMult")]
        public TartuGecko WeaponForceMult { get; set; }

        [JsonProperty("frequency")]
        public TartuGecko Frequency { get; set; }

        [JsonProperty("swankness")]
        public Swankness Swankness { get; set; }

        [JsonProperty("maxNum")]
        public TartuGecko MaxNum { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }

        [JsonProperty("plateType")]
        public PlateType PlateType { get; set; }

        [JsonProperty("dashboardType")]
        public DashboardType DashboardType { get; set; }

        [JsonProperty("vehicleClass")]
        public string VehicleClass { get; set; }

        [JsonProperty("wheelType")]
        public WheelType WheelType { get; set; }

        [JsonProperty("trailers")]
        public object Trailers { get; set; }

        [JsonProperty("additionalTrailers")]
        public object AdditionalTrailers { get; set; }

        [JsonProperty("drivers")]
        public Drivers Drivers { get; set; }

        [JsonProperty("extraIncludes")]
        public object ExtraIncludes { get; set; }

        [JsonProperty("doorsWithCollisionWhenClosed")]
        public DoorsWithCollisionWhenClosed DoorsWithCollisionWhenClosed { get; set; }

        [JsonProperty("driveableDoors")]
        public object DriveableDoors { get; set; }

        [JsonProperty("bumpersNeedToCollideWithMap")]
        public TartuGecko BumpersNeedToCollideWithMap { get; set; }

        [JsonProperty("needsRopeTexture")]
        public TartuGecko NeedsRopeTexture { get; set; }

        [JsonProperty("requiredExtras")]
        public string RequiredExtras { get; set; }

        [JsonProperty("rewards")]
        public Rewards Rewards { get; set; }

        [JsonProperty("cinematicPartCamera")]
        public CinematicPartCamera CinematicPartCamera { get; set; }

        [JsonProperty("NmBraceOverrideSet")]
        public string NmBraceOverrideSet { get; set; }

        [JsonProperty("buoyancySphereOffset")]
        public Offset BuoyancySphereOffset { get; set; }

        [JsonProperty("buoyancySphereSizeScale")]
        public TartuGecko BuoyancySphereSizeScale { get; set; }

        [JsonProperty("pOverrideRagdollThreshold")]
        public POverrideRagdollThreshold POverrideRagdollThreshold { get; set; }

        [JsonProperty("firstPersonDrivebyData", NullValueHandling = NullValueHandling.Ignore)]
        public CinematicPartCamera FirstPersonDrivebyData { get; set; }

        [JsonProperty("povTurretCameraName", NullValueHandling = NullValueHandling.Ignore)]
        public string PovTurretCameraName { get; set; }

        [JsonProperty("FirstPersonMobilePhoneSeatIKOffset", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic FirstPersonMobilePhoneSeatIkOffset { get; set; }
    }

    public partial class TartuGecko
    {
        [JsonProperty("@value")]
        public string Value { get; set; }
    }

    public partial class Offset
    {
        [JsonProperty("@x")]
        public string X { get; set; }

        [JsonProperty("@y")]
        public string Y { get; set; }

        [JsonProperty("@z")]
        public string Z { get; set; }
    }

    public partial class CinematicPartCamera
    {
        [JsonProperty("Item")]
        public DashboardType Item { get; set; }
    }

    public partial class DoorsWithCollisionWhenClosed
    {
        [JsonProperty("Item")]
        public dynamic Item { get; set; }
    }

    public partial class Drivers
    {
        [JsonProperty("Item")]
        public dynamic Item { get; set; }
    }

    public partial class DriversItem
    {
        [JsonProperty("driverName")]
        public string DriverName { get; set; }

        [JsonProperty("npcName")]
        public string NpcName { get; set; }
    }

    public partial class FirstPersonMobilePhoneSeatIkOffset
    {
        [JsonProperty("Item")]
        public List<FirstPersonMobilePhoneSeatIkOffsetItem> Item { get; set; }
    }

    public partial class FirstPersonMobilePhoneSeatIkOffsetItem
    {
        [JsonProperty("Offset")]
        public Offset Offset { get; set; }

        [JsonProperty("SeatIndex")]
        public TartuGecko SeatIndex { get; set; }
    }

    public partial class LodDistances
    {
        [JsonProperty("@content")]
        public Content Content { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }
    }

    public partial class POverrideRagdollThreshold
    {
        [JsonProperty("@type")]
        public TypeEnum Type { get; set; }
    }

    public partial class Rewards
    {
        [JsonProperty("Item")]
        public dynamic Item { get; set; }
    }

    public partial class TxdRelationships
    {
        [JsonProperty("Item")]
        public dynamic Item { get; set; }
    }

    public partial class TxdRelationshipsItem
    {
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("child")]
        public string Child { get; set; }
    }

    public partial class Xml
    {
        [JsonProperty("@version")]
        public string Version { get; set; }

        [JsonProperty("@encoding")]
        public string Encoding { get; set; }
    }

    public enum Name
    {
        Null, 
        VehMountedTurretLimo, 
        VehMountedTurretsHeli
    };

    public enum ExplosionInfo 
    { 
        ExplosionInfoBoatMedium, 
        ExplosionInfoBoatSmall, 
        ExplosionInfoBoatToro, 
        ExplosionInfoDefault,
        ExplosionInfoTruck,
        ExplosionInfoTanker,
        ExplosionInfoPropTrailer,
        ExplosionInfoJet,
        ExplosionInfoTitan,
        ExplosionInfoMarquis,
        ExplosionInfoRaptor,
        ExplosionInfoMicroLight,
        ExplosionInfoMiljet,
        ExplosionInfoBlimp2
    };

    public enum Content
    {
        FloatArray
    };

    public enum TypeEnum 
    {
        Null,
        OverrideRagdollThreshold
    };

    public enum PlateType 
    { 
        VptBackPlates,
        VptFrontAndBackPlates,
        VptNone,
        VptFrontPlates
    };

    public enum Swankness 
    {
        Swankness2,
        Swankness3, 
        Swankness4,
        Swankness5,
        Swankness1,
        Swankness0
    };

    public enum ItemType 
    {
        VehicleTypeBoat,
        VehicleTypeCar, 
        VehicleTypeHeli,
        VehicleTypeTrailer,
        VehicleTypeQuadbike,
        VehicleTypeBlimp
    };

    public enum WheelType 
    {
        VwtHiend,
        VwtMuscle, 
        VwtSport, 
        VwtSuv,
        VwtBike,
        VwtTuner,
        VwtOffroad,
        VwtLowrider,
        VwtSupermod3
    };

    public partial struct DashboardType
    {
        public string String;
        public List<string> StringArray;

        public static implicit operator DashboardType(string String) => new DashboardType { String = String };
        public static implicit operator DashboardType(List<string> StringArray) => new DashboardType { StringArray = StringArray };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                NameConverter.Singleton,
                DashboardTypeConverter.Singleton,
                ExplosionInfoConverter.Singleton,
                ContentConverter.Singleton,
                TypeEnumConverter.Singleton,
                PlateTypeConverter.Singleton,
                SwanknessConverter.Singleton,
                ItemTypeConverter.Singleton,
                WheelTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "null":
                    return Name.Null;
                case "veh_mounted_turret_limo":
                    return Name.VehMountedTurretLimo;
                case "veh_mounted_turrets_heli":
                    return Name.VehMountedTurretsHeli;
            }

            return Name.Null;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Null:
                    serializer.Serialize(writer, "null");
                    return;
                case Name.VehMountedTurretLimo:
                    serializer.Serialize(writer, "veh_mounted_turret_limo");
                    return;
                case Name.VehMountedTurretsHeli:
                    serializer.Serialize(writer, "veh_mounted_turrets_heli");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class DashboardTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DashboardType) || t == typeof(DashboardType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DashboardType { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new DashboardType { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DashboardType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DashboardType)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type DashboardType");
        }

        public static readonly DashboardTypeConverter Singleton = new DashboardTypeConverter();
    }

    internal class ExplosionInfoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExplosionInfo) || t == typeof(ExplosionInfo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "EXPLOSION_INFO_BLIMP2":
                    return ExplosionInfo.ExplosionInfoBlimp2;
                case "EXPLOSION_INFO_MILJET":
                    return ExplosionInfo.ExplosionInfoMiljet;
                case "EXPLOSION_INFO_MICROLIGHT":
                    return ExplosionInfo.ExplosionInfoMicroLight;
                case "EXPLOSION_INFO_RAPTOR":
                    return ExplosionInfo.ExplosionInfoRaptor;
                case "EXPLOSION_INFO_MARQUIS":
                    return ExplosionInfo.ExplosionInfoMarquis;
                case "EXPLOSION_INFO_TITAN":
                    return ExplosionInfo.ExplosionInfoTitan;
                case "EXPLOSION_INFO_JET":
                    return ExplosionInfo.ExplosionInfoJet;
                case "EXPLOSION_INFO_PROPTRAILER":
                    return ExplosionInfo.ExplosionInfoPropTrailer;
                case "EXPLOSION_INFO_TANKER":
                    return ExplosionInfo.ExplosionInfoTanker;
                case "EXPLOSION_INFO_TRUCK":
                    return ExplosionInfo.ExplosionInfoTruck;
                case "EXPLOSION_INFO_BOAT_MEDIUM":
                    return ExplosionInfo.ExplosionInfoBoatMedium;
                case "EXPLOSION_INFO_BOAT_SMALL":
                    return ExplosionInfo.ExplosionInfoBoatSmall;
                case "EXPLOSION_INFO_BOAT_TORO":
                    return ExplosionInfo.ExplosionInfoBoatToro;
                case "EXPLOSION_INFO_DEFAULT":
                    return ExplosionInfo.ExplosionInfoDefault;
            }
            throw new Exception("Cannot unmarshal type ExplosionInfo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExplosionInfo)untypedValue;
            switch (value)
            {
                case ExplosionInfo.ExplosionInfoBoatMedium:
                    serializer.Serialize(writer, "EXPLOSION_INFO_BOAT_MEDIUM");
                    return;
                case ExplosionInfo.ExplosionInfoBoatSmall:
                    serializer.Serialize(writer, "EXPLOSION_INFO_BOAT_SMALL");
                    return;
                case ExplosionInfo.ExplosionInfoBoatToro:
                    serializer.Serialize(writer, "EXPLOSION_INFO_BOAT_TORO");
                    return;
                case ExplosionInfo.ExplosionInfoDefault:
                    serializer.Serialize(writer, "EXPLOSION_INFO_DEFAULT");
                    return;
            }
            throw new Exception("Cannot marshal type ExplosionInfo");
        }

        public static readonly ExplosionInfoConverter Singleton = new ExplosionInfoConverter();
    }

    internal class ContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Content) || t == typeof(Content?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "float_array")
            {
                return Content.FloatArray;
            }
            throw new Exception("Cannot unmarshal type Content");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Content)untypedValue;
            if (value == Content.FloatArray)
            {
                serializer.Serialize(writer, "float_array");
                return;
            }
            throw new Exception("Cannot marshal type Content");
        }

        public static readonly ContentConverter Singleton = new ContentConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CVehicleModelInfo__CVehicleOverrideRagdollThreshold":
                    return TypeEnum.OverrideRagdollThreshold;
                case "NULL":
                    return TypeEnum.Null;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Null)
            {
                serializer.Serialize(writer, "NULL");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class PlateTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlateType) || t == typeof(PlateType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "VPT_FRONT_PLATES":
                    return PlateType.VptFrontPlates;
                case "VPT_BACK_PLATES":
                    return PlateType.VptBackPlates;
                case "VPT_FRONT_AND_BACK_PLATES":
                    return PlateType.VptFrontAndBackPlates;
                case "VPT_NONE":
                    return PlateType.VptNone;
            }
            throw new Exception("Cannot unmarshal type PlateType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlateType)untypedValue;
            switch (value)
            {
                case PlateType.VptBackPlates:
                    serializer.Serialize(writer, "VPT_BACK_PLATES");
                    return;
                case PlateType.VptFrontAndBackPlates:
                    serializer.Serialize(writer, "VPT_FRONT_AND_BACK_PLATES");
                    return;
                case PlateType.VptNone:
                    serializer.Serialize(writer, "VPT_NONE");
                    return;
            }
            throw new Exception("Cannot marshal type PlateType");
        }

        public static readonly PlateTypeConverter Singleton = new PlateTypeConverter();
    }

    internal class SwanknessConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Swankness) || t == typeof(Swankness?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "SWANKNESS_0":
                    return Swankness.Swankness0;
                case "SWANKNESS_1":
                    return Swankness.Swankness1;
                case "SWANKNESS_2":
                    return Swankness.Swankness2;
                case "SWANKNESS_3":
                    return Swankness.Swankness3;
                case "SWANKNESS_4":
                    return Swankness.Swankness4;
                case "SWANKNESS_5":
                    return Swankness.Swankness5;
            }
            throw new Exception("Cannot unmarshal type Swankness");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Swankness)untypedValue;
            switch (value)
            {
                case Swankness.Swankness2:
                    serializer.Serialize(writer, "SWANKNESS_2");
                    return;
                case Swankness.Swankness3:
                    serializer.Serialize(writer, "SWANKNESS_3");
                    return;
                case Swankness.Swankness4:
                    serializer.Serialize(writer, "SWANKNESS_4");
                    return;
                case Swankness.Swankness5:
                    serializer.Serialize(writer, "SWANKNESS_5");
                    return;
            }
            throw new Exception("Cannot marshal type Swankness");
        }

        public static readonly SwanknessConverter Singleton = new SwanknessConverter();
    }

    internal class ItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemType) || t == typeof(ItemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "VEHICLE_TYPE_BLIMP":
                    return ItemType.VehicleTypeBlimp;
                case "VEHICLE_TYPE_QUADBIKE":
                    return ItemType.VehicleTypeQuadbike;
                case "VEHICLE_TYPE_TRAILER":
                    return ItemType.VehicleTypeTrailer;
                case "VEHICLE_TYPE_BOAT":
                    return ItemType.VehicleTypeBoat;
                case "VEHICLE_TYPE_CAR":
                    return ItemType.VehicleTypeCar;
                case "VEHICLE_TYPE_HELI":
                    return ItemType.VehicleTypeHeli;
            }

            return ItemType.VehicleTypeCar;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemType)untypedValue;
            switch (value)
            {
                case ItemType.VehicleTypeBoat:
                    serializer.Serialize(writer, "VEHICLE_TYPE_BOAT");
                    return;
                case ItemType.VehicleTypeCar:
                    serializer.Serialize(writer, "VEHICLE_TYPE_CAR");
                    return;
                case ItemType.VehicleTypeHeli:
                    serializer.Serialize(writer, "VEHICLE_TYPE_HELI");
                    return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }

    internal class WheelTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WheelType) || t == typeof(WheelType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "VWT_SUPERMOD3":
                    return WheelType.VwtSupermod3;
                case "VWT_LOWRIDER":
                    return WheelType.VwtLowrider;
                case "VWT_OFFROAD":
                    return WheelType.VwtOffroad;
                case "VWT_BIKE":
                    return WheelType.VwtBike;
                case "VWT_TUNER":
                    return WheelType.VwtTuner;
                case "VWT_HIEND":
                    return WheelType.VwtHiend;
                case "VWT_MUSCLE":
                    return WheelType.VwtMuscle;
                case "VWT_SPORT":
                    return WheelType.VwtSport;
                case "VWT_SUV":
                    return WheelType.VwtSuv;
            }
            throw new Exception("Cannot unmarshal type WheelType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WheelType)untypedValue;
            switch (value)
            {
                case WheelType.VwtHiend:
                    serializer.Serialize(writer, "VWT_HIEND");
                    return;
                case WheelType.VwtMuscle:
                    serializer.Serialize(writer, "VWT_MUSCLE");
                    return;
                case WheelType.VwtSport:
                    serializer.Serialize(writer, "VWT_SPORT");
                    return;
                case WheelType.VwtSuv:
                    serializer.Serialize(writer, "VWT_SUV");
                    return;
            }
            throw new Exception("Cannot marshal type WheelType");
        }

        public static readonly WheelTypeConverter Singleton = new WheelTypeConverter();
    }
}
