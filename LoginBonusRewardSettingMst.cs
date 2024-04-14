using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterLoginBonusId), nameof(DayCount))]
public class LoginBonusRewardSettingMst : ISerializable
{
    public uint MasterLoginBonusId { get; init; }
    public int DayCount { get; init; }
    public uint MasterLoginBonusRewardId { get; init; }
    public required string ItemBackgroundSpriteName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LoginBonusRewardSettingMst() { }

    protected LoginBonusRewardSettingMst(SerializationInfo info, StreamingContext context)
    {
        MasterLoginBonusId = info.GetUInt32("_masterLoginBonusId");
        DayCount = info.GetInt32("_dayCount");
        MasterLoginBonusRewardId = info.GetUInt32("_masterLoginBonusRewardId");
        ItemBackgroundSpriteName = info.GetString("_itemBackgroundSpriteName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterLoginBonusId", MasterLoginBonusId);
        info.AddValue("_dayCount", DayCount);
        info.AddValue("_masterLoginBonusRewardId", MasterLoginBonusRewardId);
        info.AddValue("_itemBackgroundSpriteName", ItemBackgroundSpriteName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
