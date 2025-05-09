using System.Globalization;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StoryReleaseMst : IGameMst, ISerializable
{
    private const string DateTimeFormat = "yyyy/MM/dd H:mm:ss";

    public uint MasterStoryPartId { get; set; }

    public int UserRank { get; set; }
    public int GroupLevel { get; set; }
    public uint MasterLiveId { get; set; }
    public uint LiveScore { get; set; }
    public uint MasterMissionId { get; set; }
    public int EventPoint { get; set; }
    public DateTimeOffset? OpenedAtAfterEvent { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public StoryReleaseMst() { }

    protected StoryReleaseMst(SerializationInfo info, StreamingContext context)
    {
        MasterStoryPartId = info.GetUInt32("_masterStoryPartId");
        UserRank = info.GetInt32("_userRank");
        GroupLevel = info.GetInt32("_groupLevel");
        MasterLiveId = info.GetUInt32("_masterLiveId");
        LiveScore = info.GetUInt32("_liveScore");
        MasterMissionId = info.GetUInt32("_masterMissionId");
        EventPoint = info.GetInt32("_eventPoint");

        string? openedAtAfterEvent = info.GetString("_openedAtAfterEvent");
        OpenedAtAfterEvent = !String.IsNullOrEmpty(openedAtAfterEvent)
            ? DateTimeOffset.ParseExact(openedAtAfterEvent, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            : null;

        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterStoryPartId", MasterStoryPartId);
        info.AddValue("_userRank", UserRank);
        info.AddValue("_groupLevel", GroupLevel);
        info.AddValue("_masterLiveId", MasterLiveId);
        info.AddValue("_liveScore", LiveScore);
        info.AddValue("_masterMissionId", MasterMissionId);
        info.AddValue("_eventPoint", EventPoint);
        info.AddValue("_openedAtAfterEvent", OpenedAtAfterEvent?.ToString(DateTimeFormat));
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
