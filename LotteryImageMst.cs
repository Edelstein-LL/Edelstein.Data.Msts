using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryImageMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint Number { get; set; }
    public required string LogoFileName { get; set; }
    public required string InfoFileName { get; set; }
    public string[] StepupInfoFileName { get; set; } = [];
    public string[] BgFileName { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

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
