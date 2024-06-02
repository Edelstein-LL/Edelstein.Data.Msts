using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeBirthdayMst : IGameMst, ISerializable
{
    public uint MasterNoticeGeneralId { get; set; }

    public uint MasterCharacterId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeBirthdayMst() { }

    protected NoticeBirthdayMst(SerializationInfo info, StreamingContext context)
    {
        MasterNoticeGeneralId = info.GetUInt32("_masterNoticeGeneralId");
        MasterCharacterId = info.GetUInt32("_masterCharacterId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterNoticeGeneralId", MasterNoticeGeneralId);
        info.AddValue("_masterCharacterId", MasterCharacterId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
