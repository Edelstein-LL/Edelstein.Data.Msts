using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class TitleScreenMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string PrefabName { get; init; }
    public uint MasterBgmId { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public TitleScreenMst() { }

    protected TitleScreenMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        PrefabName = info.GetString("_prefabName")!;
        MasterBgmId = info.GetUInt32("_masterBgmId");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_prefabName", PrefabName);
        info.AddValue("_masterBgmId", MasterBgmId);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
