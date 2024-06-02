using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveRecommendMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public uint Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveRecommendMst() { }

    protected LiveRecommendMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Priority = info.GetUInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
