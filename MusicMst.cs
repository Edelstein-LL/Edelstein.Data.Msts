using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MusicMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string ShortName { get; init; }
    public required string Kana { get; init; }
    public required string Artist { get; init; }
    public required string DetailInfo { get; init; }
    public required string DictionaryReference { get; init; }
    public required string DictionaryComment { get; init; }
    public BandCategory BandCategory { get; init; }
    public uint MasterGroupId { get; init; }
    public required string JacketImageName { get; init; }
    public uint MasterBgmId { get; init; }
    public uint PreviewMasterBgmId { get; init; }
    public uint Locked { get; init; }
    public ObtainType ObtainType { get; init; }
    public int IsAcLevelMusic { get; init; }
    public required string ReleaseDateTime { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
