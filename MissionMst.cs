using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MissionMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Title { get; set; }
    public required string Detail { get; set; }
    public MissionType Type { get; set; }
    public uint ParentMasterMissionId { get; set; }
    public MissionConditionType ConditionType { get; set; }
    public uint[] ConditionValues { get; set; } = [];
    public int ConditionNumber { get; set; }
    public uint MasterMissionRewardId { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MissionMst() { }

    protected MissionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Title = info.GetString("_title")!;
        Detail = info.GetString("_detail")!;
        Type = (MissionType)info.GetValue("_type", typeof(MissionType))!;
        ParentMasterMissionId = info.GetUInt32("_parentMasterMissionId");
        ConditionType = (MissionConditionType)info.GetValue("_conditionType", typeof(MissionConditionType))!;
        ConditionValues = (uint[])info.GetValue("_conditionValues", typeof(uint[]))!;
        ConditionNumber = info.GetInt32("_conditionNumber");
        MasterMissionRewardId = info.GetUInt32("_masterMissionRewardId");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_title", Title);
        info.AddValue("_detail", Detail);
        info.AddValue("_type", Type);
        info.AddValue("_parentMasterMissionId", ParentMasterMissionId);
        info.AddValue("_conditionType", ConditionType);
        info.AddValue("_conditionValues", ConditionValues);
        info.AddValue("_conditionNumber", ConditionNumber);
        info.AddValue("_masterMissionRewardId", MasterMissionRewardId);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
