using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeGeneralMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public LoginNoticePhase Phase { get; set; }
    public required string NavigationTitle { get; set; }
    public uint MasterNoticeRewardId { get; set; }
    public uint DisplayableTime { get; set; }
    public uint DisplayableExpireTime { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeGeneralMst() { }

    protected NoticeGeneralMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Phase = (LoginNoticePhase)info.GetValue("_phase", typeof(LoginNoticePhase))!;
        NavigationTitle = info.GetString("_navigationTitle")!;
        MasterNoticeRewardId = info.GetUInt32("_masterNoticeRewardId");
        DisplayableTime = info.GetUInt32("_displayableTime");
        DisplayableExpireTime = info.GetUInt32("_displayableExpireTime");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_phase", Phase);
        info.AddValue("_navigationTitle", NavigationTitle);
        info.AddValue("_masterNoticeRewardId", MasterNoticeRewardId);
        info.AddValue("_displayableTime", DisplayableTime);
        info.AddValue("_displayableExpireTime", DisplayableExpireTime);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
