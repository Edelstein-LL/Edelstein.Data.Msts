using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(Number))]
public class EventPointMst : IGameMst, ISerializable
{
    public uint MasterEventId { get; set; }
    public uint Number { get; set; }
    public int Amount { get; set; }
    public uint MasterEventPointRewardId { get; set; }
    public uint RepeatInterval { get; set; }
    public uint RepeatCount { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
