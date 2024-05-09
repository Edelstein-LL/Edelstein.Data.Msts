using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(EventLiveName))]
public class EventTypeMst : IGameMst, ISerializable
{
    public EventType Type { get; set; }
    public required string EventLiveName { get; set; }
    public uint MasterMultiPenaltyId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventTypeMst() { }

    protected EventTypeMst(SerializationInfo info, StreamingContext context)
    {
        Type = (EventType)info.GetValue("_type", typeof(EventType))!;
        EventLiveName = info.GetString("_eventLiveName")!;
        MasterMultiPenaltyId = info.GetUInt32("_masterMultiPenaltyId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_type", Type);
        info.AddValue("_eventLiveName", EventLiveName);
        info.AddValue("_masterMultiPenaltyId", MasterMultiPenaltyId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
