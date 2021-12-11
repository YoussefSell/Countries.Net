namespace Countries.NET.Loader
{
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Globalization;
    using System;

    public partial class Country
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("tld", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tld { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("ccn3", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccn3 { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("cioc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cioc { get; set; }

        [JsonProperty("independent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Independent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unMember")]
        public bool UnMember { get; set; }

        [JsonProperty("currencies", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Aed> Currencies { get; set; }

        [JsonProperty("idd")]
        public Idd Idd { get; set; }

        [JsonProperty("capital", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Capital { get; set; }

        [JsonProperty("altSpellings")]
        public List<string> AltSpellings { get; set; }

        [JsonProperty("region")]
        public Region Region { get; set; }

        [JsonProperty("subregion", NullValueHandling = NullValueHandling.Ignore)]
        public string Subregion { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        [JsonProperty("latlng")]
        public List<double> Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Borders { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("demonyms", NullValueHandling = NullValueHandling.Ignore)]
        public Demonyms Demonyms { get; set; }

        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public Maps Maps { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("gini", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> Gini { get; set; }

        [JsonProperty("fifa", NullValueHandling = NullValueHandling.Ignore)]
        public string Fifa { get; set; }

        [JsonProperty("car")]
        public Car Car { get; set; }

        [JsonProperty("timezones")]
        public List<string> Timezones { get; set; }

        [JsonProperty("continents")]
        public List<string> Continents { get; set; }

        [JsonProperty("flags")]
        public CoatOfArms Flags { get; set; }

        [JsonProperty("coatOfArms")]
        public CoatOfArms CoatOfArms { get; set; }

        [JsonProperty("startOfWeek")]
        public StartOfWeek StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public PostalCode PostalCode { get; set; }
    }

    public partial class CapitalInfo
    {
        [JsonProperty("latlng", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Latlng { get; set; }
    }

    public partial class Car
    {
        [JsonProperty("signs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Signs { get; set; }

        [JsonProperty("side")]
        public Side Side { get; set; }
    }

    public partial class CoatOfArms
    {
        [JsonProperty("png", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Png { get; set; }

        [JsonProperty("svg", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Svg { get; set; }
    }

    public partial class Aed
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public partial class Bam
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Demonyms
    {
        [JsonProperty("eng")]
        public Eng Eng { get; set; }

        [JsonProperty("fra", NullValueHandling = NullValueHandling.Ignore)]
        public Eng Fra { get; set; }
    }

    public partial class Eng
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public partial class Idd
    {
        [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
        public string Root { get; set; }

        [JsonProperty("suffixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Suffixes { get; set; }
    }

    public partial class Maps
    {
        [JsonProperty("googleMaps")]
        public Uri GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Translation> NativeName { get; set; }
    }

    public partial class Translation
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public partial class PostalCode
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }
    }

    public enum Side { Left, Right };

    public enum Continent { Africa, Antarctica, Asia, Europe, NorthAmerica, Oceania, SouthAmerica };

    public enum Region { Africa, Americas, Antarctic, Asia, Europe, Oceania };

    public enum StartOfWeek { Monday, Sunday, Turday };

    public enum Status { OfficiallyAssigned, UserAssigned };
    public partial class Country
    {
        public static List<Country> FromJson(string json) => JsonConvert.DeserializeObject<List<Country>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Country> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                SideConverter.Singleton,
                ContinentConverter.Singleton,
                RegionConverter.Singleton,
                StartOfWeekConverter.Singleton,
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class SideConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Side) || t == typeof(Side?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "left":
                    return Side.Left;
                case "right":
                    return Side.Right;
            }
            throw new Exception("Cannot unmarshal type Side");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Side)untypedValue;
            switch (value)
            {
                case Side.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case Side.Right:
                    serializer.Serialize(writer, "right");
                    return;
            }
            throw new Exception("Cannot marshal type Side");
        }

        public static readonly SideConverter Singleton = new SideConverter();
    }

    internal class ContinentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Continent) || t == typeof(Continent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Africa":
                    return Continent.Africa;
                case "Antarctica":
                    return Continent.Antarctica;
                case "Asia":
                    return Continent.Asia;
                case "Europe":
                    return Continent.Europe;
                case "North America":
                    return Continent.NorthAmerica;
                case "Oceania":
                    return Continent.Oceania;
                case "South America":
                    return Continent.SouthAmerica;
            }
            throw new Exception("Cannot unmarshal type Continent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Continent)untypedValue;
            switch (value)
            {
                case Continent.Africa:
                    serializer.Serialize(writer, "Africa");
                    return;
                case Continent.Antarctica:
                    serializer.Serialize(writer, "Antarctica");
                    return;
                case Continent.Asia:
                    serializer.Serialize(writer, "Asia");
                    return;
                case Continent.Europe:
                    serializer.Serialize(writer, "Europe");
                    return;
                case Continent.NorthAmerica:
                    serializer.Serialize(writer, "North America");
                    return;
                case Continent.Oceania:
                    serializer.Serialize(writer, "Oceania");
                    return;
                case Continent.SouthAmerica:
                    serializer.Serialize(writer, "South America");
                    return;
            }
            throw new Exception("Cannot marshal type Continent");
        }

        public static readonly ContinentConverter Singleton = new ContinentConverter();
    }

    internal class RegionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Region) || t == typeof(Region?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Africa":
                    return Region.Africa;
                case "Americas":
                    return Region.Americas;
                case "Antarctic":
                    return Region.Antarctic;
                case "Asia":
                    return Region.Asia;
                case "Europe":
                    return Region.Europe;
                case "Oceania":
                    return Region.Oceania;
            }
            throw new Exception("Cannot unmarshal type Region");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Region)untypedValue;
            switch (value)
            {
                case Region.Africa:
                    serializer.Serialize(writer, "Africa");
                    return;
                case Region.Americas:
                    serializer.Serialize(writer, "Americas");
                    return;
                case Region.Antarctic:
                    serializer.Serialize(writer, "Antarctic");
                    return;
                case Region.Asia:
                    serializer.Serialize(writer, "Asia");
                    return;
                case Region.Europe:
                    serializer.Serialize(writer, "Europe");
                    return;
                case Region.Oceania:
                    serializer.Serialize(writer, "Oceania");
                    return;
            }
            throw new Exception("Cannot marshal type Region");
        }

        public static readonly RegionConverter Singleton = new RegionConverter();
    }

    internal class StartOfWeekConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StartOfWeek) || t == typeof(StartOfWeek?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "monday":
                    return StartOfWeek.Monday;
                case "sunday":
                    return StartOfWeek.Sunday;
                case "turday":
                    return StartOfWeek.Turday;
            }
            throw new Exception("Cannot unmarshal type StartOfWeek");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StartOfWeek)untypedValue;
            switch (value)
            {
                case StartOfWeek.Monday:
                    serializer.Serialize(writer, "monday");
                    return;
                case StartOfWeek.Sunday:
                    serializer.Serialize(writer, "sunday");
                    return;
                case StartOfWeek.Turday:
                    serializer.Serialize(writer, "turday");
                    return;
            }
            throw new Exception("Cannot marshal type StartOfWeek");
        }

        public static readonly StartOfWeekConverter Singleton = new StartOfWeekConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "officially-assigned":
                    return Status.OfficiallyAssigned;
                case "user-assigned":
                    return Status.UserAssigned;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.OfficiallyAssigned:
                    serializer.Serialize(writer, "officially-assigned");
                    return;
                case Status.UserAssigned:
                    serializer.Serialize(writer, "user-assigned");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
