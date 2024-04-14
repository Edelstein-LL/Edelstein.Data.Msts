using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryInfoMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string InfoText { get; init; }
    public required string DetailText { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryInfoMst() { }

    protected LotteryInfoMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        InfoText = info.GetString("_infoText")!;
        DetailText = info.GetString("_detailText")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_infoText", InfoText);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
