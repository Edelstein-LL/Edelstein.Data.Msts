using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryCautionMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string CautionText { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LotteryCautionMst() { }

    protected LotteryCautionMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        CautionText = info.GetString("_cautionText")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_cautionText", CautionText);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
