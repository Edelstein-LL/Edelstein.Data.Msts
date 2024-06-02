using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiDailyDropEffectMst : IGameMst, ISerializable
{
    public required string Name { get; set; }

    public uint MasterReleaseLabelId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }

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
