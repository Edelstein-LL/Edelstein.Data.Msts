using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(Number))]
public class EventScoreRankingMst : ISerializable
{
    public uint MasterEventId { get; init; }
    public uint GroupCount { get; init; }
    public uint Number { get; init; }
    public uint HighRank { get; init; }
    public uint LowRank { get; init; }
    public uint MasterEventScoreRankingRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EventScoreRankingMst() { }

    protected EventScoreRankingMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        GroupCount = info.GetUInt32("_groupCount");
        Number = info.GetUInt32("_number");
        HighRank = info.GetUInt32("_highRank");
        LowRank = info.GetUInt32("_lowRank");
        MasterEventScoreRankingRewardId = info.GetUInt32("_masterEventScoreRankingRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_groupCount", GroupCount);
        info.AddValue("_number", Number);
        info.AddValue("_highRank", HighRank);
        info.AddValue("_lowRank", LowRank);
        info.AddValue("_masterEventScoreRankingRewardId", MasterEventScoreRankingRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
