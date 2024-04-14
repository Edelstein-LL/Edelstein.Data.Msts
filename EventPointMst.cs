using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(Number))]
public class EventPointMst : ISerializable
{
    public uint MasterEventId { get; init; }
    public uint Number { get; init; }
    public int Amount { get; init; }
    public uint MasterEventPointRewardId { get; init; }
    public uint RepeatInterval { get; init; }
    public uint RepeatCount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EventPointMst() { }

    protected EventPointMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        Number = info.GetUInt32("_number");
        Amount = info.GetInt32("_amount");
        MasterEventPointRewardId = info.GetUInt32("_masterEventPointRewardId");
        RepeatInterval = info.GetUInt32("_repeatInterval");
        RepeatCount = info.GetUInt32("_repeatCount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_number", Number);
        info.AddValue("_amount", Amount);
        info.AddValue("_masterEventPointRewardId", MasterEventPointRewardId);
        info.AddValue("_repeatInterval", RepeatInterval);
        info.AddValue("_repeatCount", RepeatCount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
