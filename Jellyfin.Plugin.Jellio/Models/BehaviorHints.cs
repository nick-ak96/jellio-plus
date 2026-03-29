using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Jellio.Models;

public class BehaviorHints
{
    [JsonPropertyName("notWebReady")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool NotWebReady { get; set; }
}
