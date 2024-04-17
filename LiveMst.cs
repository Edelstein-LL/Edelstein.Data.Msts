using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterMusicId { get; init; }
    public required CardType Type { get; init; }
    public int ScoreC { get; init; }
    public int ScoreB { get; init; }
    public int ScoreA { get; init; }
    public int ScoreS { get; init; }
    public int MultiScoreC { get; init; }
    public int MultiScoreB { get; init; }
    public int MultiScoreA { get; init; }
    public int MultiScoreS { get; init; }
    public int LiveEffectValueId { get; init; }
    public int Bpm { get; init; }
    public float StartWait { get; init; }
    public float EndWait { get; init; }
    public uint MasterLiveRewardSettingId { get; init; }
    public uint LiveBgMovieMasterId { get; init; }
    public required string RehearsalImagePath { get; init; }
    public int Priority { get; init; }
    public int CampaignFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
