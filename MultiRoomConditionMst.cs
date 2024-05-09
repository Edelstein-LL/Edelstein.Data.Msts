using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiRoomConditionMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint Number { get; set; }
    public required uint[] Values { get; set; }
    public int Amount { get; set; }
    public uint CompareType { get; set; }
    public required string ConditionDetail { get; set; }
    public uint MasterReleaseLabelId { get; set; }
    public MultiConditionType MultiConditionType { get; set; }

    public MultiRoomConditionMst() { }

    protected MultiRoomConditionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        Values = (uint[])info.GetValue("_values", typeof(uint[]))!;
        Amount = info.GetInt32("_amount");
        CompareType = info.GetUInt32("_compareType");
        ConditionDetail = info.GetString("_conditionDetail")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
        MultiConditionType = (MultiConditionType)info.GetValue("_multiConditionType", typeof(MultiConditionType))!;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_values", Values);
        info.AddValue("_amount", Amount);
        info.AddValue("_compareType", CompareType);
        info.AddValue("_conditionDetail", ConditionDetail);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
        info.AddValue("_multiConditionType", MultiConditionType);
    }
}
