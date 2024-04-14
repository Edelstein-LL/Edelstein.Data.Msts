using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class UserRankRewardMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint Number { get; init; }
    public RewardType Type { get; init; }
    public GiveType GiveType { get; init; }
    public uint Value { get; init; }
    public int Level { get; init; }
    public int Amount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public UserRankRewardMst() { }

    protected UserRankRewardMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        Type = (RewardType)info.GetValue("_type", typeof(RewardType))!;
        GiveType = (GiveType)info.GetValue("_giveType", typeof(GiveType))!;
        Value = info.GetUInt32("_value");
        Level = info.GetInt32("_level");
        Amount = info.GetInt32("_amount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_type", Type);
        info.AddValue("_giveType", GiveType);
        info.AddValue("_value", Value);
        info.AddValue("_level", Level);
        info.AddValue("_amount", Amount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
