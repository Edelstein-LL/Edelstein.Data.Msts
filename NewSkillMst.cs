using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NewSkillMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string DetailText { get; set; }
    public SkillMainTriggerType Trigger { get; set; }
    public uint[] TriggerValue { get; set; } = [];
    public uint[] Probability { get; set; } = [];
    public uint[] EffectiveMilliSecs { get; set; } = [];
    public SkillSubTargetType SubTarget { get; set; }
    public uint TargetGroupId { get; set; }
    public uint TargetSchoolGrade { get; set; }
    public SkillMainEffectType EffectType { get; set; }
    public uint[] EffectiveValues { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public NewSkillMst() { }

    protected NewSkillMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        DetailText = info.GetString("_detailText")!;
        Trigger = (SkillMainTriggerType)info.GetValue("_trigger", typeof(SkillMainTriggerType))!;
        TriggerValue = (uint[])info.GetValue("_triggerValue", typeof(uint[]))!;
        Probability = (uint[])info.GetValue("_probability", typeof(uint[]))!;
        EffectiveMilliSecs = (uint[])info.GetValue("_effectiveMilliSecs", typeof(uint[]))!;
        SubTarget = (SkillSubTargetType)info.GetValue("_subTarget", typeof(SkillSubTargetType))!;
        TargetGroupId = info.GetUInt32("_targetGroupId");
        TargetSchoolGrade = info.GetUInt32("_targetSchoolGrade");
        EffectType = (SkillMainEffectType)info.GetValue("_effectType", typeof(SkillMainEffectType))!;
        EffectiveValues = (uint[])info.GetValue("_effectiveValues", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_trigger", Trigger);
        info.AddValue("_triggerValue", TriggerValue);
        info.AddValue("_probability", Probability);
        info.AddValue("_effectiveMilliSecs", EffectiveMilliSecs);
        info.AddValue("_subTarget", SubTarget);
        info.AddValue("_targetGroupId", TargetGroupId);
        info.AddValue("_targetSchoolGrade", TargetSchoolGrade);
        info.AddValue("_effectType", EffectType);
        info.AddValue("_effectiveValues", EffectiveValues);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
