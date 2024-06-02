using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveRewardSettingMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public LiveMode LiveMode { get; set; }
    public ScoreRank ScoreRank { get; set; }
    public uint[] MasterLiveRewardIdList { get; set; } = [];
    public uint[] RareMasterLiveRewardIdList { get; set; } = [];
    public uint EnsuredMasterLiveRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveRewardSettingMst() { }

    protected LiveRewardSettingMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        LiveMode = (LiveMode)info.GetValue("_liveMode", typeof(LiveMode))!;
        ScoreRank = (ScoreRank)info.GetValue("_scoreRank", typeof(ScoreRank))!;
        MasterLiveRewardIdList = (uint[])info.GetValue("_masterLiveRewardIdList", typeof(uint[]))!;
        RareMasterLiveRewardIdList = (uint[])info.GetValue("_rareMasterLiveRewardIdList", typeof(uint[]))!;
        EnsuredMasterLiveRewardId = info.GetUInt32("_ensuredMasterLiveRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_liveMode", LiveMode);
        info.AddValue("_scoreRank", ScoreRank);
        info.AddValue("_masterLiveRewardIdList", MasterLiveRewardIdList);
        info.AddValue("_rareMasterLiveRewardIdList", RareMasterLiveRewardIdList);
        info.AddValue("_ensuredMasterLiveRewardId", EnsuredMasterLiveRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
