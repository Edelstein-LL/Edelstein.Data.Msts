using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Level))]
public class StarEventLevelMst : ISerializable
{
    public uint Id { get; init; }
    public uint Level { get; init; }
    public int LiveScoreCoefficient { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StarEventLevelMst() { }

    protected StarEventLevelMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Level = info.GetUInt32("_level");
        LiveScoreCoefficient = info.GetInt32("_liveScoreCoefficient");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_level", Level);
        info.AddValue("_liveScoreCoefficient", LiveScoreCoefficient);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
