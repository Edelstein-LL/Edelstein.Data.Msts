using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMissionMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public LiveMissionType Type { get; set; }
    public LiveLevel Level { get; set; }
    public required string Value { get; set; }
    public uint MasterLiveMissionRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
