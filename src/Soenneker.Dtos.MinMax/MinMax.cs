using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.MinMax;

/// <summary>
/// A minimal Record type with a Min (decimal) and a Max (decimal) and maximum JSON compatibility
/// </summary>
/// <remarks>Record type, avoid modification</remarks>
[PublicOpenApiObject]
public record MinMax
{
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    [Required]
    [JsonPropertyName("min")]
    [JsonProperty("min")]
    public decimal Min { get; set; }

    /// <summary>
    /// Gets or sets max.
    /// </summary>
    [Required]
    [JsonPropertyName("max")]
    [JsonProperty("max")]
    public decimal Max { get; set; }
}