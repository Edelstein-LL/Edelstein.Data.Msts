using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(StarId))]
public class StarEventSettingMst : ISerializable
{
    public uint Id { get; init; }
    public uint StarId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
