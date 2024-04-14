using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class SkillCenterEffectMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint TargetSchoolGrade { get; init; }
    public uint TargetGroupId { get; init; }
    public SkillCardType TargetCardType { get; init; }
    public uint CalcType { get; init; }
    public uint Value { get; init; }
    public StatusUpType TargetParam { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public SkillCenterEffectMst() { }

    protected SkillCenterEffectMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        TargetSchoolGrade = info.GetUInt32("_targetSchoolGrade");
        TargetGroupId = info.GetUInt32("_targetGroupId");
        TargetCardType = (SkillCardType)info.GetValue("_targetCardType", typeof(SkillCardType))!;
        CalcType = info.GetUInt32("_calcType");
        Value = info.GetUInt32("_value");
        TargetParam = (StatusUpType)info.GetValue("_targetParam", typeof(StatusUpType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_targetSchoolGrade", TargetSchoolGrade);
        info.AddValue("_targetGroupId", TargetGroupId);
        info.AddValue("_targetCardType", TargetCardType);
        info.AddValue("_calcType", CalcType);
        info.AddValue("_value", Value);
        info.AddValue("_targetParam", TargetParam);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
