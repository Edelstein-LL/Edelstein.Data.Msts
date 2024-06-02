using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardRarityMst : IGameMst, ISerializable
{
    public Rarity Rarity { get; set; }

    public int MaxLevel { get; set; }
    public int BaseEvolveCount { get; set; }
    public uint MasterCardSkillLevelId { get; set; }
    public uint ExchangeMasterItemId { get; set; }
    public int ExchangeItemAmount { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
