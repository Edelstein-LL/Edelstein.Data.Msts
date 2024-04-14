using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveClearRewardMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterLiveId { get; init; }
    public RewardType Type { get; init; }
    public uint Value { get; init; }
    public int Amount { get; init; }
    public int Priority { get; init; }
    public int GetableCount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveClearRewardMst() { }

    protected LiveClearRewardMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterLiveId = info.GetUInt32("_masterLiveId");
        Type = (RewardType)info.GetValue("_type", typeof(RewardType))!;
        Value = info.GetUInt32("_value");
        Amount = info.GetInt32("_amount");
        Priority = info.GetInt32("_priority");
        GetableCount = info.GetInt32("_getableCount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterLiveId", MasterLiveId);
        info.AddValue("_type", Type);
        info.AddValue("_value", Value);
        info.AddValue("_amount", Amount);
        info.AddValue("_priority", Priority);
        info.AddValue("_getableCount", GetableCount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
