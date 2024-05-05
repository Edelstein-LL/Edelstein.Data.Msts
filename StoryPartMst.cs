using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StoryPartMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint MasterStoryId { get; set; }
    public uint Number { get; set; }
    public required string Name { get; set; }
    public uint MasterStoryRewardId { get; set; }
    public uint MasterMusicId { get; set; }
    public uint ScenarioId { get; set; }
    public uint[] MovieIds { get; set; } = [];
    public required string ImageName { get; set; }
    public uint StampCharacterId { get; set; }
    public uint StoreReviewSetting { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
        MovieIds = (uint[])info.GetValue("_movieIds", typeof(uint[]))!;
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
        info.AddValue("_movieIds", MovieIds);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_stampCharacterId", StampCharacterId);
        info.AddValue("_storeReviewSetting", StoreReviewSetting);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
