using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StoryPartMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterStoryId { get; init; }
    public uint Number { get; init; }
    public required string Name { get; init; }
    public uint MasterStoryRewardId { get; init; }
    public uint MasterMusicId { get; init; }
    public uint ScenarioId { get; init; }
    public required string ImageName { get; init; }
    public uint StampCharacterId { get; init; }
    public uint StoreReviewSetting { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StoryPartMst() { }

    protected StoryPartMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterStoryId = info.GetUInt32("_masterStoryId");
        Number = info.GetUInt32("_number");
        Name = info.GetString("_name")!;
        MasterStoryRewardId = info.GetUInt32("_masterStoryRewardId");
        MasterMusicId = info.GetUInt32("_masterMusicId");
        ScenarioId = info.GetUInt32("_scenarioId");
        ImageName = info.GetString("_imageName")!;
        StampCharacterId = info.GetUInt32("_stampCharacterId");
        StoreReviewSetting = info.GetUInt32("_storeReviewSetting");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterStoryId", MasterStoryId);
        info.AddValue("_number", Number);
        info.AddValue("_name", Name);
        info.AddValue("_masterStoryRewardId", MasterStoryRewardId);
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_scenarioId", ScenarioId);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_stampCharacterId", StampCharacterId);
        info.AddValue("_storeReviewSetting", StoreReviewSetting);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
