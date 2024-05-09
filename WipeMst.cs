using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class WipeMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string PrefabPath { get; set; }
    public required string ReadySeKey { get; set; }
    public required string WipeSeKey { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public WipeMst() { }

    protected WipeMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        PrefabPath = info.GetString("_prefabPath")!;
        ReadySeKey = info.GetString("_readySeKey")!;
        WipeSeKey = info.GetString("_wipeSeKey")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_prefabPath", PrefabPath);
        info.AddValue("_readySeKey", ReadySeKey);
        info.AddValue("_wipeSeKey", WipeSeKey);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
