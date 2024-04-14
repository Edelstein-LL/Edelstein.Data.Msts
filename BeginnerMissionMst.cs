using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Number), nameof(Level))]
public class BeginnerMissionMst : ISerializable
{
    public uint Id { get; init; }
    public uint Level { get; init; }
    public uint Number { get; init; }
    public uint MasterMissionId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public BeginnerMissionMst() { }

    protected BeginnerMissionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Level = info.GetUInt32("_level");
        Number = info.GetUInt32("_number");
        MasterMissionId = info.GetUInt32("_masterMissionId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_level", Level);
        info.AddValue("_number", Number);
        info.AddValue("_masterMissionId", MasterMissionId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
