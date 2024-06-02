using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class UserRankRewardMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint Number { get; set; }
    public RewardType Type { get; set; }
    public GiveType GiveType { get; set; }
    public uint Value { get; set; }
    public int Level { get; set; }
    public int Amount { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
