using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(SpriteName))]
public class EventTipsPageMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public required string SpriteName { get; set; }
    public required string Message { get; set; }
    public required string Category { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventTipsPageMst() { }

    protected EventTipsPageMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        SpriteName = info.GetString("_spriteName")!;
        Message = info.GetString("_message")!;
        Category = info.GetString("_category")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_message", Message);
        info.AddValue("_category", Category);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
