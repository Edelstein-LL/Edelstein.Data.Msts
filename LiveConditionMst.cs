using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveConditionMst : IGameMst, ISerializable
{
    public uint MasterLiveId { get; set; }

    public uint Number { get; set; }
    public required string Detail { get; set; }
    public LiveConditionType Type { get; set; }
    public uint[] Values { get; set; } = [];
    public int Amount { get; set; }
    public uint CompareType { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
