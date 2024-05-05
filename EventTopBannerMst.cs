using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(MasterGachaId))]
public class EventTopBannerMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public uint MasterGachaId { get; set; }
    public required string SpriteName { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventTopBannerMst() { }

    protected EventTopBannerMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        MasterGachaId = info.GetUInt32("_masterGachaId");
        SpriteName = info.GetString("_spriteName")!;
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_masterGachaId", MasterGachaId);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
