using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeCardImageMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string ImageName { get; set; }
    public uint MasterLotteryId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
