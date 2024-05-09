using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(PlayerCount), nameof(LiveRank), nameof(EventPtBonus))]
public class MultieventRankbonusMst : IGameMst, ISerializable
{
    public uint PlayerCount { get; set; }
    public uint LiveRank { get; set; }
    public int EventPtBonus { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MultieventRankbonusMst() { }

    protected MultieventRankbonusMst(SerializationInfo info, StreamingContext context)
    {
        PlayerCount = info.GetUInt32("_playerCount");
        LiveRank = info.GetUInt32("_liveRank");
        EventPtBonus = info.GetInt32("_eventPtBonus");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_playerCount", PlayerCount);
        info.AddValue("_liveRank", LiveRank);
        info.AddValue("_eventPtBonus", EventPtBonus);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
