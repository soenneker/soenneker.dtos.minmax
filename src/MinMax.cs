using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.MinMax;

/// <summary>
/// A minimal Record type with a Min (decimal) and a Max (decimal) and maximum JSON compatibility
/// </summary>
/// <remarks>Record type, avoid modification</remarks>
[DataContract]
public record MinMax
{
    [Required]
    [DataMember(Name = "min")]
    [JsonPropertyName("min")]
    [JsonProperty("min")]
    public decimal Min { get; set; }

    [Required]
    [DataMember(Name = "max")]
    [JsonPropertyName("max")]
    [JsonProperty("max")]
    public decimal Max { get; set; }
}