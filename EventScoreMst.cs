using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EventScoreMst : ISerializable
{
    [Key]
    public uint MasterEventId { get; set; }

    public int EventLivePointBase { get; set; }
    public int EventPointRatio { get; set; }
    public int EventBoostRatio { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
