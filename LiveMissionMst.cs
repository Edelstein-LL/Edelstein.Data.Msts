using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMissionMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public LiveMissionType Type { get; init; }
    public LiveLevel Level { get; init; }
    public required string Value { get; init; }
    public uint MasterLiveMissionRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveMissionMst() { }

    protected LiveMissionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Type = (LiveMissionType)info.GetValue("_type", typeof(LiveMissionType))!;
        Level = (LiveLevel)info.GetValue("_level", typeof(LiveLevel))!;
        Value = info.GetString("_value")!;
        MasterLiveMissionRewardId = info.GetUInt32("_masterLiveMissionRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_type", Type);
        info.AddValue("_level", Level);
        info.AddValue("_value", Value);
        info.AddValue("_masterLiveMissionRewardId", MasterLiveMissionRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
