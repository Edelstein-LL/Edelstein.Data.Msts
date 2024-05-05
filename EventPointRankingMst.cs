using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(GroupId), nameof(Number))]
public class EventPointRankingMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public uint GroupId { get; set; }
    public uint Number { get; set; }
    public uint HighRank { get; set; }
    public uint LowRank { get; set; }
    public uint MasterEventPointRankingRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventPointRankingMst() { }

    protected EventPointRankingMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        GroupId = info.GetUInt32("_groupId");
        Number = info.GetUInt32("_number");
        HighRank = info.GetUInt32("_highRank");
        LowRank = info.GetUInt32("_lowRank");
        MasterEventPointRankingRewardId = info.GetUInt32("_masterEventPointRankingRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_groupId", GroupId);
        info.AddValue("_number", Number);
        info.AddValue("_highRank", HighRank);
        info.AddValue("_lowRank", LowRank);
        info.AddValue("_masterEventPointRankingRewardId", MasterEventPointRankingRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
