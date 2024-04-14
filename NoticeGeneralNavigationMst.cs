using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeGeneralNavigationMst : ISerializable
{
    [Key]
    public uint MasterNoticeGeneralId { get; init; }

    public uint Order { get; init; }
    public required string SpriteName { get; init; }
    public required string Message { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
