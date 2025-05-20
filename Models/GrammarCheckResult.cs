using System.Text.Json.Serialization;

namespace EduScriptAI.Models
{
    public class GrammarCheckResult
    {
        [JsonPropertyName("matches")]
        public List<GrammarMatch> Matches { get; set; } = new();

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }

    public class GrammarMatch
    {
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("length")]
        public int Length { get; set; }

        [JsonPropertyName("replacements")]
        public List<GrammarReplacement> Replacements { get; set; } = new();
    }

    public class GrammarReplacement
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
} 