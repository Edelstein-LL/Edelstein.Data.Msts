using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(MasterStoryId))]
public class EventStoryMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public uint MasterStoryId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventStoryMst() { }

    protected EventStoryMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        MasterStoryId = info.GetUInt32("_masterStoryId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_masterStoryId", MasterStoryId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
