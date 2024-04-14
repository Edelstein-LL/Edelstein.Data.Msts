using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ReleaseLabelMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Description { get; init; }
    public uint ReleaseStatus { get; init; }
    public required string Scope { get; init; }
    public required string OpenedAt { get; init; }
    public required string ClosedAt { get; init; }

    public ReleaseLabelMst() { }

    protected ReleaseLabelMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Description = info.GetString("_description")!;
        ReleaseStatus = info.GetUInt32("_releaseStatus");
        Scope = info.GetString("_scope")!;
        OpenedAt = info.GetString("_openedAt")!;
        ClosedAt = info.GetString("_closedAt")!;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_description", Description);
        info.AddValue("_releaseStatus", ReleaseStatus);
        info.AddValue("_scope", Scope);
        info.AddValue("_openedAt", OpenedAt);
        info.AddValue("_closedAt", ClosedAt);
    }
}
