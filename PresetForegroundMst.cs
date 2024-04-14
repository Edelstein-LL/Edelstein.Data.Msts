using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class PresetForegroundMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public PresetForegroundType Type { get; init; }
    public required string Filename { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public PresetForegroundMst() { }

    protected PresetForegroundMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Type = (PresetForegroundType)info.GetValue("_type", typeof(PresetForegroundType))!;
        Filename = info.GetString("_filename")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_type", Type);
        info.AddValue("_filename", Filename);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
