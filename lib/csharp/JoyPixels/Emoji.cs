using Newtonsoft.Json;

namespace JoyPixels
{
    public class CodePoints
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("fully_qualified")]
        public string FullyQualified { get; set; }

        [JsonProperty("decimal")]
        public string Decimal { get; set; }

        [JsonProperty("diversity_parent")]
        public string DiversityParent { get; set; }
    
        [JsonProperty("gender_parent")]
        public string GenderParent { get; set; }
    }

    public class Emoji
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unicode_version")]
        public float UnicodeVersion { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("display")]
        public int Display { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("shortname_alternates")]
        public string[] ShortnameAlternates { get; set; }

        [JsonProperty("ascii")]
        public string[] Ascii { get; set; }

        [JsonProperty("humanform")]
        public int Humanform { get; set; }

        [JsonProperty("diversity_base")]
        public int DiversityBase { get; set; }

        [JsonProperty("diversity")]
        public string[] Diversity { get; set; }

        [JsonProperty("diversity_children")]
        public string[] DiversityChildren { get; set; }

        [JsonProperty("gender")]
        public string[] Gender { get; set; }

        [JsonProperty("gender_children")]
        public string[] GenderChildren { get; set; }

        [JsonProperty("code_points")]
        public CodePoints CodePoints { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }
    }
}
