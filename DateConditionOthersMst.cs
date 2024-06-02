using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DateConditionOthersMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public uint Num { get; set; }
    public required string Date { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public DateConditionOthersMst() { }

    protected DateConditionOthersMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Num = info.GetUInt32("_num");
        Date = info.GetString("_date")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_num", Num);
        info.AddValue("_date", Date);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
