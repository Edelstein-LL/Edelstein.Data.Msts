using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint MasterMusicId { get; set; }
    public required CardType Type { get; set; }
    public int ScoreC { get; set; }
    public int ScoreB { get; set; }
    public int ScoreA { get; set; }
    public int ScoreS { get; set; }
    public int MultiScoreC { get; set; }
    public int MultiScoreB { get; set; }
    public int MultiScoreA { get; set; }
    public int MultiScoreS { get; set; }
    public int LiveEffectValueId { get; set; }
    public int Bpm { get; set; }
    public float StartWait { get; set; }
    public float EndWait { get; set; }
    public uint MasterLiveRewardSettingId { get; set; }
    public uint LiveBgMovieMasterId { get; set; }
    public required string RehearsalImagePath { get; set; }
    public int Priority { get; set; }
    public int CampaignFlag { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveMst() { }

    protected LiveMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterMusicId = info.GetUInt32("_masterMusicId");
        Type = (CardType)info.GetValue("_type", typeof(CardType))!;
        ScoreC = info.GetInt32("_scoreC");
        ScoreB = info.GetInt32("_scoreB");
        ScoreA = info.GetInt32("_scoreA");
        ScoreS = info.GetInt32("_scoreS");
        MultiScoreC = info.GetInt32("_multiScoreC");
        MultiScoreB = info.GetInt32("_multiScoreB");
        MultiScoreA = info.GetInt32("_multiScoreA");
        MultiScoreS = info.GetInt32("_multiScoreS");
        LiveEffectValueId = info.GetInt32("_liveEffectValueId");
        Bpm = info.GetInt32("_bpm");
        StartWait = info.GetSingle("_startWait");
        EndWait = info.GetSingle("_endWait");
        MasterLiveRewardSettingId = info.GetUInt32("_masterLiveRewardSettingId");
        LiveBgMovieMasterId = info.GetUInt32("_liveBgMovieMasterId");
        RehearsalImagePath = info.GetString("_rehearsalImagePath")!;
        Priority = info.GetInt32("_priority");
        CampaignFlag = info.GetInt32("_campaignFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_type", Type);
        info.AddValue("_scoreC", ScoreC);
        info.AddValue("_scoreB", ScoreB);
        info.AddValue("_scoreA", ScoreA);
        info.AddValue("_scoreS", ScoreS);
        info.AddValue("_multiScoreC", MultiScoreC);
        info.AddValue("_multiScoreB", MultiScoreB);
        info.AddValue("_multiScoreA", MultiScoreA);
        info.AddValue("_multiScoreS", MultiScoreS);
        info.AddValue("_liveEffectValueId", LiveEffectValueId);
        info.AddValue("_bpm", Bpm);
        info.AddValue("_startWait", StartWait);
        info.AddValue("_endWait", EndWait);
        info.AddValue("_masterLiveRewardSettingId", MasterLiveRewardSettingId);
        info.AddValue("_liveBgMovieMasterId", LiveBgMovieMasterId);
        info.AddValue("_rehearsalImagePath", RehearsalImagePath);
        info.AddValue("_priority", Priority);
        info.AddValue("_campaignFlag", CampaignFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }

    public int GetScoreByLetter(string letter) =>
        letter switch
        {
            "C" => ScoreC,
            "B" => ScoreB,
            "A" => ScoreA,
            "S" => ScoreS,
            _ => throw new ArgumentOutOfRangeException(nameof(letter))
        };
}
