using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GTA5_RealHandlingNames.Models
{
    public partial class VehicleHandling
    {
        [JsonProperty("?xml")]
        public Xml Xml { get; set; }

        [JsonProperty("CHandlingDataMgr")]
        public CHandlingDataMgr CHandlingDataMgr { get; set; }

        public static VehicleHandling FromJson(string json) => JsonConvert.DeserializeObject<VehicleHandling>(json, Converter.Settings);
    }

    public partial class CHandlingDataMgr
    {
        [JsonProperty("HandlingData")]
        public HandlingData HandlingData { get; set; }
    }

    public partial class HandlingData
    {
        [JsonProperty("Item")]
        public HandlingDataItem Item { get; set; }
    }

    public partial class HandlingDataItem
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("handlingName")]
        public string HandlingName { get; set; }

        [JsonProperty("fMass")]
        public ItemValue FMass { get; set; }

        [JsonProperty("fInitialDragCoeff")]
        public ItemValue FInitialDragCoeff { get; set; }

        [JsonProperty("fPercentSubmerged")]
        public ItemValue FPercentSubmerged { get; set; }

        [JsonProperty("vecCentreOfMassOffset")]
        public Vec VecCentreOfMassOffset { get; set; }

        [JsonProperty("vecInertiaMultiplier")]
        public Vec VecInertiaMultiplier { get; set; }

        [JsonProperty("fDriveBiasFront")]
        public ItemValue FDriveBiasFront { get; set; }

        [JsonProperty("nInitialDriveGears")]
        public ItemValue NInitialDriveGears { get; set; }

        [JsonProperty("fInitialDriveForce")]
        public ItemValue FInitialDriveForce { get; set; }

        [JsonProperty("fDriveInertia")]
        public ItemValue FDriveInertia { get; set; }

        [JsonProperty("fClutchChangeRateScaleUpShift")]
        public ItemValue FClutchChangeRateScaleUpShift { get; set; }

        [JsonProperty("fClutchChangeRateScaleDownShift")]
        public ItemValue FClutchChangeRateScaleDownShift { get; set; }

        [JsonProperty("fInitialDriveMaxFlatVel")]
        public ItemValue FInitialDriveMaxFlatVel { get; set; }

        [JsonProperty("fBrakeForce")]
        public ItemValue FBrakeForce { get; set; }

        [JsonProperty("fBrakeBiasFront")]
        public ItemValue FBrakeBiasFront { get; set; }

        [JsonProperty("fHandBrakeForce")]
        public ItemValue FHandBrakeForce { get; set; }

        [JsonProperty("fSteeringLock")]
        public ItemValue FSteeringLock { get; set; }

        [JsonProperty("fTractionCurveMax")]
        public ItemValue FTractionCurveMax { get; set; }

        [JsonProperty("fTractionCurveMin")]
        public ItemValue FTractionCurveMin { get; set; }

        [JsonProperty("fTractionCurveLateral")]
        public ItemValue FTractionCurveLateral { get; set; }

        [JsonProperty("fTractionSpringDeltaMax")]
        public ItemValue FTractionSpringDeltaMax { get; set; }

        [JsonProperty("fLowSpeedTractionLossMult")]
        public ItemValue FLowSpeedTractionLossMult { get; set; }

        [JsonProperty("fCamberStiffnesss")]
        public ItemValue FCamberStiffnesss { get; set; }

        [JsonProperty("fTractionBiasFront")]
        public ItemValue FTractionBiasFront { get; set; }

        [JsonProperty("fTractionLossMult")]
        public ItemValue FTractionLossMult { get; set; }

        [JsonProperty("fSuspensionForce")]
        public ItemValue FSuspensionForce { get; set; }

        [JsonProperty("fSuspensionCompDamp")]
        public ItemValue FSuspensionCompDamp { get; set; }

        [JsonProperty("fSuspensionReboundDamp")]
        public ItemValue FSuspensionReboundDamp { get; set; }

        [JsonProperty("fSuspensionUpperLimit")]
        public ItemValue FSuspensionUpperLimit { get; set; }

        [JsonProperty("fSuspensionLowerLimit")]
        public ItemValue FSuspensionLowerLimit { get; set; }

        [JsonProperty("fSuspensionRaise")]
        public ItemValue FSuspensionRaise { get; set; }

        [JsonProperty("fSuspensionBiasFront")]
        public ItemValue FSuspensionBiasFront { get; set; }

        [JsonProperty("fAntiRollBarForce")]
        public ItemValue FAntiRollBarForce { get; set; }

        [JsonProperty("fAntiRollBarBiasFront")]
        public ItemValue ItemValue { get; set; }

        [JsonProperty("fRollCentreHeightFront")]
        public ItemValue FRollCentreHeightFront { get; set; }

        [JsonProperty("fRollCentreHeightRear")]
        public ItemValue FRollCentreHeightRear { get; set; }

        [JsonProperty("fCollisionDamageMult")]
        public ItemValue FCollisionDamageMult { get; set; }

        [JsonProperty("fWeaponDamageMult")]
        public ItemValue FWeaponDamageMult { get; set; }

        [JsonProperty("fDeformationDamageMult")]
        public ItemValue FDeformationDamageMult { get; set; }

        [JsonProperty("fEngineDamageMult")]
        public ItemValue FEngineDamageMult { get; set; }

        [JsonProperty("fPetrolTankVolume")]
        public ItemValue FPetrolTankVolume { get; set; }

        [JsonProperty("fOilVolume")]
        public ItemValue FOilVolume { get; set; }

        [JsonProperty("fSeatOffsetDistX")]
        public ItemValue FSeatOffsetDistX { get; set; }

        [JsonProperty("fSeatOffsetDistY")]
        public ItemValue FSeatOffsetDistY { get; set; }

        [JsonProperty("fSeatOffsetDistZ")]
        public ItemValue FSeatOffsetDistZ { get; set; }

        [JsonProperty("nMonetaryValue")]
        public ItemValue NMonetaryValue { get; set; }

        [JsonProperty("strModelFlags")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StrModelFlags { get; set; }

        [JsonProperty("strHandlingFlags")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StrHandlingFlags { get; set; }

        [JsonProperty("strDamageFlags")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StrDamageFlags { get; set; }

        [JsonProperty("AIHandling")]
        public string AiHandling { get; set; }

        [JsonProperty("SubHandlingData")]
        public SubHandlingData SubHandlingData { get; set; }
    }

    public partial class ItemValue
    {
        [JsonProperty("@value")]
        public string Value { get; set; }
    }

    public partial class SubHandlingData
    {
        [JsonProperty("Item")]
        public List<ItemElement> Item { get; set; }
    }

    public partial class ItemElement
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("fBackEndPopUpCarImpulseMult", NullValueHandling = NullValueHandling.Ignore)]
        public ItemValue FBackEndPopUpCarImpulseMult { get; set; }

        [JsonProperty("fBackEndPopUpBuildingImpulseMult", NullValueHandling = NullValueHandling.Ignore)]
        public ItemValue FBackEndPopUpBuildingImpulseMult { get; set; }

        [JsonProperty("fBackEndPopUpMaxDeltaSpeed", NullValueHandling = NullValueHandling.Ignore)]
        public ItemValue FBackEndPopUpMaxDeltaSpeed { get; set; }
    }

    public partial class Vec
    {
        [JsonProperty("@x")]
        public string X { get; set; }

        [JsonProperty("@y")]
        public string Y { get; set; }

        [JsonProperty("@z")]
        public string Z { get; set; }
    }

    public partial class Xml
    {
        [JsonProperty("@version")]
        public string Version { get; set; }

        [JsonProperty("@encoding")]
        public string Encoding { get; set; }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
