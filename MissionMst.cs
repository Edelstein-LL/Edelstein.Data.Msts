using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MissionMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Title { get; init; }
    public required string Detail { get; init; }
    public MissionType Type { get; init; }
    public uint ParentMasterMissionId { get; init; }
    public MissionConditionType ConditionType { get; init; }
    public int ConditionNumber { get; init; }
    public uint MasterMissionRewardId { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MissionMst() { }

    protected MissionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Title = info.GetString("_title")!;
        Detail = info.GetString("_detail")!;
        Type = (MissionType)info.GetValue("_type", typeof(MissionType))!;
        ParentMasterMissionId = info.GetUInt32("_parentMasterMissionId");
        ConditionType = (MissionConditionType)info.GetValue("_conditionType", typeof(MissionConditionType))!;
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
        info.AddValue("_conditionNumber", ConditionNumber);
        info.AddValue("_masterMissionRewardId", MasterMissionRewardId);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
