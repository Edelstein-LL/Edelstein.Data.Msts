using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class GroupMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public BandCategory Category { get; set; }
    public required string ImageColor { get; set; }
    public required string RecommendListTextColor { get; set; }
    public int SortPriority { get; set; }
    public uint RecommendedDeckView { get; set; }
    public int IsCategoryJudge { get; set; }
    public uint MusicSelectSortView { get; set; }
    public required string HomeBgmSoundKey { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public GroupMst() { }

    protected GroupMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Category = (BandCategory)info.GetValue("_category", typeof(BandCategory))!;
        ImageColor = info.GetString("_imageColor")!;
        RecommendListTextColor = info.GetString("_recommendListTextColor")!;
        SortPriority = info.GetInt32("_sortPriority");
        RecommendedDeckView = info.GetUInt32("_recommendedDeckView");
        IsCategoryJudge = info.GetInt32("_isCategoryJudge");
        MusicSelectSortView = info.GetUInt32("_musicSelectSortView");
        HomeBgmSoundKey = info.GetString("_homeBgmSoundKey")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_category", Category);
        info.AddValue("_imageColor", ImageColor);
        info.AddValue("_recommendListTextColor", RecommendListTextColor);
        info.AddValue("_sortPriority", SortPriority);
        info.AddValue("_recommendedDeckView", RecommendedDeckView);
        info.AddValue("_isCategoryJudge", IsCategoryJudge);
        info.AddValue("_musicSelectSortView", MusicSelectSortView);
        info.AddValue("_homeBgmSoundKey", HomeBgmSoundKey);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
