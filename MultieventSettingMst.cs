using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultieventSettingMst : IGameMst, ISerializable
{
    public uint EventId { get; set; }

    public required string Name { get; set; }
    public EventType Type { get; set; }
    public uint[] TargetGroupIds { get; set; } = [];
    public required CardType TargetType { get; set; }
    public uint LeftLiveButtonCharaId { get; set; }
    public uint RightLiveButtonCharaId { get; set; }
    public LiveLevel NeedHelperLevel { get; set; }
    public int NeedHelperPower { get; set; }
    public int NeedHelperRank { get; set; }
    public required string NeedHelpableMessage { get; set; }
    public LiveLevel ExclusionLevel { get; set; }
    public int HelpCount { get; set; }
    public int RoomWaitSec { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MultieventSettingMst() { }

    protected MultieventSettingMst(SerializationInfo info, StreamingContext context)
    {
        EventId = info.GetUInt32("_eventId");
        Name = info.GetString("_name")!;
        Type = (EventType)info.GetValue("_type", typeof(EventType))!;
        TargetGroupIds = (uint[])info.GetValue("_targetGroupIds", typeof(uint[]))!;
        TargetType = (CardType)info.GetValue("_targetType", typeof(CardType))!;
        LeftLiveButtonCharaId = info.GetUInt32("_leftLiveButtonCharaId");
        RightLiveButtonCharaId = info.GetUInt32("_rightLiveButtonCharaId");
        NeedHelperLevel = (LiveLevel)info.GetValue("_needHelperLevel", typeof(LiveLevel))!;
        NeedHelperPower = info.GetInt32("_needHelperPower");
        NeedHelperRank = info.GetInt32("_needHelperRank");
        NeedHelpableMessage = info.GetString("_needHelpableMessage")!;
        ExclusionLevel = (LiveLevel)info.GetValue("_exclusionLevel", typeof(LiveLevel))!;
        HelpCount = info.GetInt32("_helpCount");
        RoomWaitSec = info.GetInt32("_roomWaitSec");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_eventId", EventId);
        info.AddValue("_name", Name);
        info.AddValue("_type", Type);
        info.AddValue("_targetGroupIds", TargetGroupIds);
        info.AddValue("_targetType", TargetType);
        info.AddValue("_leftLiveButtonCharaId", LeftLiveButtonCharaId);
        info.AddValue("_rightLiveButtonCharaId", RightLiveButtonCharaId);
        info.AddValue("_needHelperLevel", NeedHelperLevel);
        info.AddValue("_needHelperPower", NeedHelperPower);
        info.AddValue("_needHelperRank", NeedHelperRank);
        info.AddValue("_needHelpableMessage", NeedHelpableMessage);
        info.AddValue("_exclusionLevel", ExclusionLevel);
        info.AddValue("_helpCount", HelpCount);
        info.AddValue("_roomWaitSec", RoomWaitSec);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
