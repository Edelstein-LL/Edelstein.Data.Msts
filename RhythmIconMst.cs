using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class RhythmIconMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string AtlasName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public RhythmIconMst() { }

    protected RhythmIconMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        AtlasName = info.GetString("_atlasName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_atlasName", AtlasName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
