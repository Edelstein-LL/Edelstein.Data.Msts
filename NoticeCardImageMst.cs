using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeCardImageMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string ImageName { get; init; }
    public uint MasterLotteryId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public NoticeCardImageMst() { }

    protected NoticeCardImageMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        ImageName = info.GetString("_imageName")!;
        MasterLotteryId = info.GetUInt32("_masterLotteryId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_masterLotteryId", MasterLotteryId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
