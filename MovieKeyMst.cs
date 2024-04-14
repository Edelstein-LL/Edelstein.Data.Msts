using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MovieKeyMst : ISerializable
{
    [Key]
    public required string Key { get; init; }

    public uint MasterMovieId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MovieKeyMst() { }

    protected MovieKeyMst(SerializationInfo info, StreamingContext context)
    {
        Key = info.GetString("_key")!;
        MasterMovieId = info.GetUInt32("_masterMovieId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_key", Key);
        info.AddValue("_masterMovieId", MasterMovieId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
