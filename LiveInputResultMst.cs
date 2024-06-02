using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveInputResultMst : IGameMst, ISerializable
{
    public InputResultType Type { get; set; }

    public float OffsetTimeSec { get; set; }
    public float OffsetTimeSecSlider { get; set; }
    public float ScoreCoeff { get; set; }
    public int LifeDamage { get; set; }
    public int MidpointLifeDamage { get; set; }
    public int BombLifeDamage { get; set; }
    public int EnableCombo { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveInputResultMst() { }

    protected LiveInputResultMst(SerializationInfo info, StreamingContext context)
    {
        Type = (InputResultType)info.GetValue("_type", typeof(InputResultType))!;
        OffsetTimeSec = info.GetSingle("_offsetTimeSec");
        OffsetTimeSecSlider = info.GetSingle("_offsetTimeSecSlider");
        ScoreCoeff = info.GetSingle("_scoreCoeff");
        LifeDamage = info.GetInt32("_lifeDamage");
        MidpointLifeDamage = info.GetInt32("_midpointLifeDamage");
        BombLifeDamage = info.GetInt32("_bombLifeDamage");
        EnableCombo = info.GetInt32("_enableCombo");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_type", Type);
        info.AddValue("_offsetTimeSec", OffsetTimeSec);
        info.AddValue("_offsetTimeSecSlider", OffsetTimeSecSlider);
        info.AddValue("_scoreCoeff", ScoreCoeff);
        info.AddValue("_lifeDamage", LifeDamage);
        info.AddValue("_midpointLifeDamage", MidpointLifeDamage);
        info.AddValue("_bombLifeDamage", BombLifeDamage);
        info.AddValue("_enableCombo", EnableCombo);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
