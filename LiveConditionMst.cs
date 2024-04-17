using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveConditionMst : ISerializable
{
    [Key]
    public uint MasterLiveId { get; init; }

    public uint Number { get; init; }
    public required string Detail { get; init; }
    public LiveConditionType Type { get; init; }
    public uint[] Values { get; init; } = [];
    public int Amount { get; init; }
    public uint CompareType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveConditionMst() { }

    protected LiveConditionMst(SerializationInfo info, StreamingContext context)
    {
        MasterLiveId = info.GetUInt32("_masterLiveId");
        Number = info.GetUInt32("_number");
        Detail = info.GetString("_detail")!;
        Type = (LiveConditionType)info.GetValue("_type", typeof(LiveConditionType))!;
        Values = (uint[])info.GetValue("_values", typeof(uint[]))!;
        Amount = info.GetInt32("_amount");
        CompareType = info.GetUInt32("_compareType");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterLiveId", MasterLiveId);
        info.AddValue("_number", Number);
        info.AddValue("_detail", Detail);
        info.AddValue("_type", Type);
        info.AddValue("_values", Values);
        info.AddValue("_amount", Amount);
        info.AddValue("_compareType", CompareType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
