using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EventScoreMst : ISerializable
{
    [Key]
    public uint MasterEventId { get; init; }

    public int EventLivePointBase { get; init; }
    public int EventPointRatio { get; init; }
    public int EventBoostRatio { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EventScoreMst() { }

    protected EventScoreMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        EventLivePointBase = info.GetInt32("_eventLivePointBase");
        EventPointRatio = info.GetInt32("_eventPointRatio");
        EventBoostRatio = info.GetInt32("_eventBoostRatio");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_eventLivePointBase", EventLivePointBase);
        info.AddValue("_eventPointRatio", EventPointRatio);
        info.AddValue("_eventBoostRatio", EventBoostRatio);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
