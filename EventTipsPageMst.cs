using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(SpriteName))]
public class EventTipsPageMst : ISerializable
{
    public uint MasterEventId { get; init; }
    public required string SpriteName { get; init; }
    public required string Message { get; init; }
    public required string Category { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
