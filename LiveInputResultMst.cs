using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveInputResultMst : ISerializable
{
    [Key]
    public InputResultType Type { get; init; }

    public float OffsetTimeSec { get; init; }
    public float OffsetTimeSecSlider { get; init; }
    public float ScoreCoeff { get; init; }
    public int LifeDamage { get; init; }
    public int MidpointLifeDamage { get; init; }
    public int BombLifeDamage { get; init; }
    public int EnableCombo { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
