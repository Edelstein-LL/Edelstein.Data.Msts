using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AdjustTrackingListMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string TrackingId { get; init; }
    public TrackingType TrackingType { get; init; }
    public required string Value { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AdjustTrackingListMst() { }

    protected AdjustTrackingListMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        TrackingId = info.GetString("_trackingId")!;
        TrackingType = (TrackingType)info.GetValue("_trackingType", typeof(TrackingType))!;
        Value = info.GetString("_value")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_trackingId", TrackingId);
        info.AddValue("_trackingType", TrackingType);
        info.AddValue("_value", Value);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}