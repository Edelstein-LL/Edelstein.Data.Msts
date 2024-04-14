using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CharacterMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string NameRuby { get; init; }
    public required string DetailText { get; init; }
    public BandCategory Category { get; init; }
    public uint SchoolGrade { get; init; }
    public uint CharaCategory { get; init; }
    public uint MasterGroupId { get; init; }
    public required string SpriteName { get; init; }
    public int DisplayOrder { get; init; }
    public required string Height { get; init; }
    public required string BloodType { get; init; }
    public required string Birsday { get; init; }
    public required string VoiceActor { get; init; }
    public required string ImageColor { get; init; }
    public required string ImageColorDark { get; init; }
    public required string NameRichtextGacha { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CharacterMst() { }

    protected CharacterMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        NameRuby = info.GetString("_nameRuby")!;
        DetailText = info.GetString("_detailText")!;
        Category = (BandCategory)info.GetValue("_category", typeof(BandCategory))!;
        SchoolGrade = info.GetUInt32("_schoolGrade");
        CharaCategory = info.GetUInt32("_charaCategory");
        MasterGroupId = info.GetUInt32("_masterGroupId");
        SpriteName = info.GetString("_spriteName")!;
        DisplayOrder = info.GetInt32("_displayOrder");
        Height = info.GetString("_height")!;
        BloodType = info.GetString("_bloodType")!;
        Birsday = info.GetString("_birsday")!;
        VoiceActor = info.GetString("_voiceActor")!;
        ImageColor = info.GetString("_imageColor")!;
        ImageColorDark = info.GetString("_imageColorDark")!;
        NameRichtextGacha = info.GetString("_nameRichtextGacha")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_nameRuby", NameRuby);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_category", Category);
        info.AddValue("_schoolGrade", SchoolGrade);
        info.AddValue("_charaCategory", CharaCategory);
        info.AddValue("_masterGroupId", MasterGroupId);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_displayOrder", DisplayOrder);
        info.AddValue("_height", Height);
        info.AddValue("_bloodType", BloodType);
        info.AddValue("_birsday", Birsday);
        info.AddValue("_voiceActor", VoiceActor);
        info.AddValue("_imageColor", ImageColor);
        info.AddValue("_imageColorDark", ImageColorDark);
        info.AddValue("_nameRichtextGacha", NameRichtextGacha);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
