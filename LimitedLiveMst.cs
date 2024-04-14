using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LimitedLiveMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string NameMasterTextId { get; init; }
    public required string RuleFormatMasterTextId { get; init; }
    public uint BonusMasterLiveId { get; init; }
    public int BonusLiveLotteryRatio { get; init; }
    public required string BonusEffectMasterTextId { get; init; }
    public int Count { get; init; }
    public uint MasterItemId { get; init; }
    public int Priority { get; init; }
    public TimeResetType TimeResetType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LimitedLiveMst() { }

    protected LimitedLiveMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        NameMasterTextId = info.GetString("_nameMasterTextId")!;
        RuleFormatMasterTextId = info.GetString("_ruleFormatMasterTextId")!;
        BonusMasterLiveId = info.GetUInt32("_bonusMasterLiveId");
        BonusLiveLotteryRatio = info.GetInt32("_bonusLiveLotteryRatio");
        BonusEffectMasterTextId = info.GetString("_bonusEffectMasterTextId")!;
        Count = info.GetInt32("_count");
        MasterItemId = info.GetUInt32("_masterItemId");
        Priority = info.GetInt32("_priority");
        TimeResetType = (TimeResetType)info.GetValue("_timeResetType", typeof(TimeResetType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_nameMasterTextId", NameMasterTextId);
        info.AddValue("_ruleFormatMasterTextId", RuleFormatMasterTextId);
        info.AddValue("_bonusMasterLiveId", BonusMasterLiveId);
        info.AddValue("_bonusLiveLotteryRatio", BonusLiveLotteryRatio);
        info.AddValue("_bonusEffectMasterTextId", BonusEffectMasterTextId);
        info.AddValue("_count", Count);
        info.AddValue("_masterItemId", MasterItemId);
        info.AddValue("_priority", Priority);
        info.AddValue("_timeResetType", TimeResetType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
