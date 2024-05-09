using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeGeneralNavigationMst : IGameMst, ISerializable
{
    [Key]
    public uint MasterNoticeGeneralId { get; set; }

    public uint Order { get; set; }
    public required string SpriteName { get; set; }
    public required string Message { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeGeneralNavigationMst() { }

    protected NoticeGeneralNavigationMst(SerializationInfo info, StreamingContext context)
    {
        MasterNoticeGeneralId = info.GetUInt32("_masterNoticeGeneralId");
        Order = info.GetUInt32("_order");
        SpriteName = info.GetString("_spriteName")!;
        Message = info.GetString("_message")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterNoticeGeneralId", MasterNoticeGeneralId);
        info.AddValue("_order", Order);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_message", Message);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
