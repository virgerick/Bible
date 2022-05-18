using Newtonsoft.Json;

namespace Bible.Application.Interfaces.Serialization.Settings;
public interface IJsonSerializerSettings
{
    /// <summary>
    /// Settings for <see cref="Newtonsoft.Json"/>.
    /// </summary>
    public JsonSerializerSettings JsonSerializerSettings { get; }
}
