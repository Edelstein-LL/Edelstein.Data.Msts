using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class SkillCenterMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string DetailText { get; init; }
    public uint[] Effects { get; init; } = [];
    public uint MasterReleaseLabelId { get; init; }

    public SkillCenterMst() { }

    protected SkillCenterMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        DetailText = info.GetString("_detailText")!;
        Effects = (uint[])info.GetValue("_effects", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_effects", Effects);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
