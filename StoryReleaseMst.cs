using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StoryReleaseMst : ISerializable
{
    [Key]
    public uint MasterStoryPartId { get; init; }

    public int UserRank { get; init; }
    public int GroupLevel { get; init; }
    public uint MasterLiveId { get; init; }
    public uint LiveScore { get; init; }
    public uint MasterMissionId { get; init; }
    public int EventPoint { get; init; }
    public required string OpenedAtAfterEvent { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
        OpenedAtAfterEvent = info.GetString("_openedAtAfterEvent")!;
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
        info.AddValue("_openedAtAfterEvent", OpenedAtAfterEvent);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
