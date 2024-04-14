using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(LiveMode), nameof(ScoreRank))]
public class LiveRewardSettingMst : ISerializable
{
    public uint Id { get; init; }
    public LiveMode LiveMode { get; init; }
    public ScoreRank ScoreRank { get; init; }
    public uint EnsuredMasterLiveRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveRewardSettingMst() { }

    protected LiveRewardSettingMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        LiveMode = (LiveMode)info.GetValue("_liveMode", typeof(LiveMode))!;
        ScoreRank = (ScoreRank)info.GetValue("_scoreRank", typeof(ScoreRank))!;
        EnsuredMasterLiveRewardId = info.GetUInt32("_ensuredMasterLiveRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_liveMode", LiveMode);
        info.AddValue("_scoreRank", ScoreRank);
        info.AddValue("_ensuredMasterLiveRewardId", EnsuredMasterLiveRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
