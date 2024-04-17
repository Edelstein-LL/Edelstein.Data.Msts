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
    public string[] StepupInfoFileName { get; init; } = [];
    public string[] BgFileName { get; init; } = [];
    public uint MasterReleaseLabelId { get; init; }

    public LotteryImageMst() { }

    protected LotteryImageMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        LogoFileName = info.GetString("_logoFileName")!;
        InfoFileName = info.GetString("_infoFileName")!;
        StepupInfoFileName = (string[])info.GetValue("_stepupInfoFileName", typeof(string[]))!;
        BgFileName = (string[])info.GetValue("_bgFileName", typeof(string[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_logoFileName", LogoFileName);
        info.AddValue("_infoFileName", InfoFileName);
        info.AddValue("_stepupInfoFileName", StepupInfoFileName);
        info.AddValue("_bgFileName", BgFileName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
