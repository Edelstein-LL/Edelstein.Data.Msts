using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardRarityMst : ISerializable
{
    [Key]
    public Rarity Rarity { get; init; }

    public int MaxLevel { get; init; }
    public int BaseEvolveCount { get; init; }
    public uint MasterCardSkillLevelId { get; init; }
    public uint ExchangeMasterItemId { get; init; }
    public int ExchangeItemAmount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CardRarityMst() { }

    protected CardRarityMst(SerializationInfo info, StreamingContext context)
    {
        Rarity = (Rarity)info.GetValue("_rarity", typeof(Rarity))!;
        MaxLevel = info.GetInt32("_maxLevel");
        BaseEvolveCount = info.GetInt32("_baseEvolveCount");
        MasterCardSkillLevelId = info.GetUInt32("_masterCardSkillLevelId");
        ExchangeMasterItemId = info.GetUInt32("_exchangeMasterItemId");
        ExchangeItemAmount = info.GetInt32("_exchangeItemAmount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_rarity", Rarity);
        info.AddValue("_maxLevel", MaxLevel);
        info.AddValue("_baseEvolveCount", BaseEvolveCount);
        info.AddValue("_masterCardSkillLevelId", MasterCardSkillLevelId);
        info.AddValue("_exchangeMasterItemId", ExchangeMasterItemId);
        info.AddValue("_exchangeItemAmount", ExchangeItemAmount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
