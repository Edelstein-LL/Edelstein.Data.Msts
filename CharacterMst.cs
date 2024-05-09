using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CharacterMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string NameRuby { get; set; }
    public required string DetailText { get; set; }
    public BandCategory Category { get; set; }
    public uint SchoolGrade { get; set; }
    public uint CharaCategory { get; set; }
    public uint MasterGroupId { get; set; }
    public required string SpriteName { get; set; }
    public int DisplayOrder { get; set; }
    public required string Height { get; set; }
    public required string BloodType { get; set; }
    public required string Birsday { get; set; }
    public required string VoiceActor { get; set; }
    public required string ImageColor { get; set; }
    public required string ImageColorDark { get; set; }
    public required string NameRichtextGacha { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
