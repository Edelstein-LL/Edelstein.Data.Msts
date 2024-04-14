using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveLaneSkinMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string LanePath { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveLaneSkinMst() { }

    protected LiveLaneSkinMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        LanePath = info.GetString("_lanePath")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_lanePath", LanePath);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}