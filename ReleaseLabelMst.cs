using System.Globalization;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ReleaseLabelMst : ISerializable
{
    private const string DateTimeFormat = "yyyy/MM/dd H:mm:ss";

    public uint Id { get; set; }

    public required string Description { get; set; }
    public uint ReleaseStatus { get; set; }
    public required string Scope { get; set; }
    public DateTimeOffset? OpenedAt { get; set; }
    public DateTimeOffset? ClosedAt { get; set; }

    public ReleaseLabelMst() { }

    protected ReleaseLabelMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Description = info.GetString("_description")!;
        ReleaseStatus = info.GetUInt32("_releaseStatus");
        Scope = info.GetString("_scope")!;

        string? openedAt = info.GetString("_openedAt");
        OpenedAt = !String.IsNullOrEmpty(openedAt)
            ? DateTimeOffset.ParseExact(openedAt, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            : null;

        string? closedAt = info.GetString("_closedAt");
        ClosedAt = !String.IsNullOrEmpty(closedAt)
            ? DateTimeOffset.ParseExact(closedAt, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            : null;
    }

    public bool IsOpen(DateTimeOffset? currentDateTimeOffset)
    {
        if (ReleaseStatus != 1)
            return false;

        if (OpenedAt.HasValue)
        {
            if (!(OpenedAt <= currentDateTimeOffset))
                return false;
        }

        if (ClosedAt.HasValue)
            return ClosedAt > currentDateTimeOffset;

        return true;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_description", Description);
        info.AddValue("_releaseStatus", ReleaseStatus);
        info.AddValue("_scope", Scope);

        info.AddValue("_openedAt", OpenedAt?.ToString(DateTimeFormat));
        info.AddValue("_closedAt", ClosedAt?.ToString(DateTimeFormat));
    }
}
