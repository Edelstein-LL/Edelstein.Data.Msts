using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EventPointSettingsMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
