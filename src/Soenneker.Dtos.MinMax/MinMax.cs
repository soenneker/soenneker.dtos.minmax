using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.MinMax;

/// <summary>
/// Defines an inclusive decimal interval with minimum and maximum bounds.
/// </summary>
[PublicOpenApiObject]
public record MinMax
{
    /// <summary>
    /// Inclusive lower bound of the interval.
    /// </summary>
    [Required]
    [JsonPropertyName("min")]
    [JsonProperty("min")]
    public decimal Min { get; set; }

    /// <summary>
    /// Inclusive upper bound of the interval.
    /// </summary>
    [Required]
    [JsonPropertyName("max")]
    [JsonProperty("max")]
    public decimal Max { get; set; }
}
