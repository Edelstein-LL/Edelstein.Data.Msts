using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class PresetForegroundMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public PresetForegroundType Type { get; set; }
    public required string Filename { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
