using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeGeneralSequenceMst : ISerializable
{
    [Key]
    public uint MasterNoticeGeneralId { get; init; }

    public uint Order { get; init; }
    public LoginNoticeType Type { get; init; }
    public required string Value { get; init; }
    public uint MasterBgmId { get; init; }
    public LoginNoticeTransition EndTransition { get; init; }
    public uint SkippableFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public NoticeGeneralSequenceMst() { }

    protected NoticeGeneralSequenceMst(SerializationInfo info, StreamingContext context)
    {
        MasterNoticeGeneralId = info.GetUInt32("_masterNoticeGeneralId");
        Order = info.GetUInt32("_order");
        Type = (LoginNoticeType)info.GetValue("_type", typeof(LoginNoticeType))!;
        Value = info.GetString("_value")!;
        MasterBgmId = info.GetUInt32("_masterBgmId");
        EndTransition = (LoginNoticeTransition)info.GetValue("_endTransition", typeof(LoginNoticeTransition))!;
        SkippableFlag = info.GetUInt32("_skippableFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterNoticeGeneralId", MasterNoticeGeneralId);
        info.AddValue("_order", Order);
        info.AddValue("_type", Type);
        info.AddValue("_value", Value);
        info.AddValue("_masterBgmId", MasterBgmId);
        info.AddValue("_endTransition", EndTransition);
        info.AddValue("_skippableFlag", SkippableFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}