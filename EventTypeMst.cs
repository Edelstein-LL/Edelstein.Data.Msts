using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(EventLiveName))]
public class EventTypeMst : ISerializable
{
    public EventType Type { get; init; }
    public required string EventLiveName { get; init; }
    public uint MasterMultiPenaltyId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
