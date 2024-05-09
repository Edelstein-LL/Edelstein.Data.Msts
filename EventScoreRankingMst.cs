using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(Number))]
public class EventScoreRankingMst : IGameMst, ISerializable
{
    public uint MasterEventId { get; set; }
    public uint GroupCount { get; set; }
    public uint Number { get; set; }
    public uint HighRank { get; set; }
    public uint LowRank { get; set; }
    public uint MasterEventScoreRankingRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
