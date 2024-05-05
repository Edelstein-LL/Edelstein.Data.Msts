using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(MasterLiveId))]
public class EventLiveMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public uint MasterLiveId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventLiveMst() { }

    protected EventLiveMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        MasterLiveId = info.GetUInt32("_masterLiveId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_masterLiveId", MasterLiveId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
