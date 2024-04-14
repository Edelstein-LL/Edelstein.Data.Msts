using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(GroupId), nameof(Number))]
public class EventMemberRankingMst : ISerializable
{
    public uint MasterEventId { get; init; }
    public uint GroupId { get; init; }
    public uint Number { get; init; }
    public uint HighRank { get; init; }
    public uint LowRank { get; init; }
    public uint MasterEventMemberRankingRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EventMemberRankingMst() { }

    protected EventMemberRankingMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        GroupId = info.GetUInt32("_groupId");
        Number = info.GetUInt32("_number");
        HighRank = info.GetUInt32("_highRank");
        LowRank = info.GetUInt32("_lowRank");
        MasterEventMemberRankingRewardId = info.GetUInt32("_masterEventMemberRankingRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_groupId", GroupId);
        info.AddValue("_number", Number);
        info.AddValue("_highRank", HighRank);
        info.AddValue("_lowRank", LowRank);
        info.AddValue("_masterEventMemberRankingRewardId", MasterEventMemberRankingRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}