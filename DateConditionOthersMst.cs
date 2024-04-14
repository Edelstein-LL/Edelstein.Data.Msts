using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Num))]
public class DateConditionOthersMst : ISerializable
{
    public uint Id { get; init; }
    public uint Num { get; init; }
    public required string Date { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
