using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiDailyDropEffectMst : ISerializable
{
    [Key]
    public required string Name { get; init; }

    public uint MasterReleaseLabelId { get; init; }
    public DayOfWeek DayOfWeek { get; init; }

    public MultiDailyDropEffectMst() { }

    protected MultiDailyDropEffectMst(SerializationInfo info, StreamingContext context)
    {
        Name = info.GetString("_text")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
        DayOfWeek = (DayOfWeek)info.GetValue("_dayOfWeek", typeof(DayOfWeek))!;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_text", Name);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
        info.AddValue("_dayOfWeek", DayOfWeek);
    }
}
