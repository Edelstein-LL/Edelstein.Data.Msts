using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BgmMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint Num { get; init; }
    public required string CueSheetName { get; init; }
    public required string CueName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public BgmMst() { }

    protected BgmMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Num = info.GetUInt32("_num");
        CueSheetName = info.GetString("_cueSheetName")!;
        CueName = info.GetString("_cueName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_num", Num);
        info.AddValue("_cueSheetName", CueSheetName);
        info.AddValue("_cueName", CueName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
