using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MovieMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public MovieLengthType LengthType { get; init; }
    public MovieScreenType ScreenType { get; init; }
    public required string MovieName { get; init; }
    public required string MovieDetail { get; init; }
    public uint[] MasterCharacterIdList { get; init; } = [];
    public uint MasterCharacterId { get; init; }
    public required string FolderPath { get; init; }
    public required string FileName { get; init; }
    public required string ThumbnailSpriteName { get; init; }
    public GetCategory GetCategory { get; init; }
    public uint[] MasterMusicIdList { get; init; } = [];
    public uint MasterReleaseLabelId { get; init; }

    public MovieMst() { }

    protected MovieMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        LengthType = (MovieLengthType)info.GetValue("_lengthType", typeof(MovieLengthType))!;
        ScreenType = (MovieScreenType)info.GetValue("_screenType", typeof(MovieScreenType))!;
        MovieName = info.GetString("_movieName")!;
        MovieDetail = info.GetString("_movieDetail")!;
        MasterCharacterIdList = (uint[])info.GetValue("_masterCharacterIdList", typeof(uint[]))!;
        MasterCharacterId = info.GetUInt32("_masterCharacterId");
        FolderPath = info.GetString("_folderPath")!;
        FileName = info.GetString("_fileName")!;
        ThumbnailSpriteName = info.GetString("_thumbnailSpriteName")!;
        GetCategory = (GetCategory)info.GetValue("_getCategory", typeof(GetCategory))!;
        MasterMusicIdList = (uint[])info.GetValue("_masterMusicIdList", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_lengthType", LengthType);
        info.AddValue("_screenType", ScreenType);
        info.AddValue("_movieName", MovieName);
        info.AddValue("_movieDetail", MovieDetail);
        info.AddValue("_masterCharacterIdList", MasterCharacterIdList);
        info.AddValue("_masterCharacterId", MasterCharacterId);
        info.AddValue("_folderPath", FolderPath);
        info.AddValue("_fileName", FileName);
        info.AddValue("_thumbnailSpriteName", ThumbnailSpriteName);
        info.AddValue("_getCategory", GetCategory);
        info.AddValue("_masterMusicIdList", MasterMusicIdList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
