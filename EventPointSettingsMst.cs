using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EventPointSettingsMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EventPointSettingsMst() { }

    protected EventPointSettingsMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
