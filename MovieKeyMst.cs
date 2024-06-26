using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MovieKeyMst : IGameMst, ISerializable
{
    public required string Key { get; set; }

    public uint MasterMovieId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
