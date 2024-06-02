using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryItemMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public uint Number { get; set; }
    public RewardType Type { get; set; }
    public uint Value { get; set; }
    public int Amount { get; set; }
    public int Priority { get; set; }
    public uint Pickup { get; set; }
    public uint Show { get; set; }
    public uint BoxCount { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
