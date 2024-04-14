using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StoryMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public StoryType Type { get; init; }
    public uint MasterGroupId { get; init; }
    public uint SeasonNumber { get; init; }
    public uint ChapterNumber { get; init; }
    public required string Name { get; init; }
    public required string Summary { get; init; }
    public required string ImageName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StoryMst() { }

    protected StoryMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Type = (StoryType)info.GetValue("_type", typeof(StoryType))!;
        MasterGroupId = info.GetUInt32("_masterGroupId");
        SeasonNumber = info.GetUInt32("_seasonNumber");
        ChapterNumber = info.GetUInt32("_chapterNumber");
        Name = info.GetString("_name")!;
        Summary = info.GetString("_summary")!;
        ImageName = info.GetString("_imageName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_type", Type);
        info.AddValue("_masterGroupId", MasterGroupId);
        info.AddValue("_seasonNumber", SeasonNumber);
        info.AddValue("_chapterNumber", ChapterNumber);
        info.AddValue("_name", Name);
        info.AddValue("_summary", Summary);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}