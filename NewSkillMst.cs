using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NewSkillMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string DetailText { get; init; }
    public SkillMainTriggerType Trigger { get; init; }
    public SkillSubTargetType SubTarget { get; init; }
    public uint TargetGroupId { get; init; }
    public uint TargetSchoolGrade { get; init; }
    public SkillMainEffectType EffectType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public NewSkillMst() { }

    protected NewSkillMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        DetailText = info.GetString("_detailText")!;
        Trigger = (SkillMainTriggerType)info.GetValue("_trigger", typeof(SkillMainTriggerType))!;
        SubTarget = (SkillSubTargetType)info.GetValue("_subTarget", typeof(SkillSubTargetType))!;
        TargetGroupId = info.GetUInt32("_targetGroupId");
        TargetSchoolGrade = info.GetUInt32("_targetSchoolGrade");
        EffectType = (SkillMainEffectType)info.GetValue("_effectType", typeof(SkillMainEffectType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_trigger", Trigger);
        info.AddValue("_subTarget", SubTarget);
        info.AddValue("_targetGroupId", TargetGroupId);
        info.AddValue("_targetSchoolGrade", TargetSchoolGrade);
        info.AddValue("_effectType", EffectType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
