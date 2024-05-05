using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterBeginnerMissionId), nameof(Level), nameof(Number))]
public class BeginnerMissionRewardSettingMst : ISerializable
{
    public uint MasterBeginnerMissionId { get; set; }
    public uint Level { get; set; }
    public uint Number { get; set; }
    public uint MasterBeginnerMissionRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public BeginnerMissionRewardSettingMst() { }

    protected BeginnerMissionRewardSettingMst(SerializationInfo info, StreamingContext context)
    {
        MasterBeginnerMissionId = info.GetUInt32("_masterBeginnerMissionId");
        Level = info.GetUInt32("_level");
        Number = info.GetUInt32("_number");
        MasterBeginnerMissionRewardId = info.GetUInt32("_masterBeginnerMissionRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterBeginnerMissionId", MasterBeginnerMissionId);
        info.AddValue("_level", Level);
        info.AddValue("_number", Number);
        info.AddValue("_masterBeginnerMissionRewardId", MasterBeginnerMissionRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
