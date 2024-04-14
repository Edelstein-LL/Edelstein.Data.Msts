using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(TargetId))]
public class StarEventCardBonusMst : ISerializable
{
    public uint MasterEventId { get; init; }
    public uint TargetId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StarEventCardBonusMst() { }

    protected StarEventCardBonusMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        TargetId = info.GetUInt32("_targetId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_targetId", TargetId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
