using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MusicMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string ShortName { get; set; }
    public required string Kana { get; set; }
    public required string Artist { get; set; }
    public required string DetailInfo { get; set; }
    public required string DictionaryReference { get; set; }
    public required string DictionaryComment { get; set; }
    public BandCategory BandCategory { get; set; }
    public uint MasterGroupId { get; set; }
    public required string JacketImageName { get; set; }
    public uint MasterBgmId { get; set; }
    public uint PreviewMasterBgmId { get; set; }
    public uint Locked { get; set; }
    public ObtainType ObtainType { get; set; }
    public int IsAcLevelMusic { get; set; }
    public required string ReleaseDateTime { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MusicMst() { }

    protected MusicMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        ShortName = info.GetString("_shortName")!;
        Kana = info.GetString("_kana")!;
        Artist = info.GetString("_artist")!;
        DetailInfo = info.GetString("_detailInfo")!;
        DictionaryReference = info.GetString("_dictionaryReference")!;
        DictionaryComment = info.GetString("_dictionaryComment")!;
        BandCategory = (BandCategory)info.GetValue("_bandCategory", typeof(BandCategory))!;
        MasterGroupId = info.GetUInt32("_masterGroupId");
        JacketImageName = info.GetString("_jacketImageName")!;
        MasterBgmId = info.GetUInt32("_masterBgmId");
        PreviewMasterBgmId = info.GetUInt32("_previewMasterBgmId");
        Locked = info.GetUInt32("_locked");
        ObtainType = (ObtainType)info.GetValue("_obtainType", typeof(ObtainType))!;
        IsAcLevelMusic = info.GetInt32("_isAcLevelMusic");
        ReleaseDateTime = info.GetString("_releaseDateTime")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_shortName", ShortName);
        info.AddValue("_kana", Kana);
        info.AddValue("_artist", Artist);
        info.AddValue("_detailInfo", DetailInfo);
        info.AddValue("_dictionaryReference", DictionaryReference);
        info.AddValue("_dictionaryComment", DictionaryComment);
        info.AddValue("_bandCategory", BandCategory);
        info.AddValue("_masterGroupId", MasterGroupId);
        info.AddValue("_jacketImageName", JacketImageName);
        info.AddValue("_masterBgmId", MasterBgmId);
        info.AddValue("_previewMasterBgmId", PreviewMasterBgmId);
        info.AddValue("_locked", Locked);
        info.AddValue("_obtainType", ObtainType);
        info.AddValue("_isAcLevelMusic", IsAcLevelMusic);
        info.AddValue("_releaseDateTime", ReleaseDateTime);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
