using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryImageMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint Number { get; init; }
    public required string LogoFileName { get; init; }
    public required string InfoFileName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryImageMst() { }

    protected LotteryImageMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        LogoFileName = info.GetString("_logoFileName")!;
        InfoFileName = info.GetString("_infoFileName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_logoFileName", LogoFileName);
        info.AddValue("_infoFileName", InfoFileName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
