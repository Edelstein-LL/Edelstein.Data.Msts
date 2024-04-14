using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Number))]
[Index(nameof(Id))]
public class LotteryItemMst : ISerializable
{
    public uint Id { get; init; }
    public uint Number { get; init; }
    public RewardType Type { get; init; }
    public uint Value { get; init; }
    public int Amount { get; init; }
    public int Priority { get; init; }
    public uint Pickup { get; init; }
    public uint Show { get; init; }
    public uint BoxCount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryItemMst() { }

    protected LotteryItemMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        Type = (RewardType)info.GetValue("_type", typeof(RewardType))!;
        Value = info.GetUInt32("_value");
        Amount = info.GetInt32("_amount");
        Priority = info.GetInt32("_priority");
        Pickup = info.GetUInt32("_pickup");
        Show = info.GetUInt32("_show");
        BoxCount = info.GetUInt32("_boxCount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_type", Type);
        info.AddValue("_value", Value);
        info.AddValue("_amount", Amount);
        info.AddValue("_priority", Priority);
        info.AddValue("_pickup", Pickup);
        info.AddValue("_show", Show);
        info.AddValue("_boxCount", BoxCount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
