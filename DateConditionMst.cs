using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DateConditionMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public DateConditionType DateConditionType { get; init; }
    public uint Arg1 { get; init; }
    public uint Arg2 { get; init; }
    public uint Arg3 { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public DateConditionMst() { }

    protected DateConditionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        DateConditionType = (DateConditionType)info.GetValue("_dateConditionType", typeof(DateConditionType))!;
        Arg1 = info.GetUInt32("_arg1");
        Arg2 = info.GetUInt32("_arg2");
        Arg3 = info.GetUInt32("_arg3");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_dateConditionType", DateConditionType);
        info.AddValue("_arg1", Arg1);
        info.AddValue("_arg2", Arg2);
        info.AddValue("_arg3", Arg3);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
