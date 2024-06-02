using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DateConditionMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public DateConditionType DateConditionType { get; set; }
    public uint Arg1 { get; set; }
    public uint Arg2 { get; set; }
    public uint Arg3 { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
