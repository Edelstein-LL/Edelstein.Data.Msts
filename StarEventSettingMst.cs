using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StarEventSettingMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public uint StarId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public StarEventSettingMst() { }

    protected StarEventSettingMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        StarId = info.GetUInt32("_starId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_starId", StarId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
