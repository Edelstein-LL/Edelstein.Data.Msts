using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(RootPath))]
public class EventTipsMst : IGameMst, ISerializable
{
    public uint MasterEventId { get; set; }
    public required string Title { get; set; }
    public required string RootPath { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public EventTipsMst() { }

    protected EventTipsMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        Title = info.GetString("_title")!;
        RootPath = info.GetString("_rootPath")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_title", Title);
        info.AddValue("_rootPath", RootPath);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
