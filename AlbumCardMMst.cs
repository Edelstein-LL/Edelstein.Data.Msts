using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumCardMMst : ISerializable
{
    [Key]
    public uint CardId { get; set; }

    public int NaviMoveX { get; set; }
    public int NaviMoveY { get; set; }
    public required string ThumbnailName { get; set; }
    public required string SignedThumbnailName { get; set; }
    public required string AssetName { get; set; }
    public required string SignedAssetName { get; set; }
    public int IsBgActive { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public AlbumCardMMst() { }

    protected AlbumCardMMst(SerializationInfo info, StreamingContext context)
    {
        CardId = info.GetUInt32("_cardId");
        NaviMoveX = info.GetInt32("_naviMoveX");
        NaviMoveY = info.GetInt32("_naviMoveY");
        ThumbnailName = info.GetString("_thumbnailName")!;
        SignedThumbnailName = info.GetString("_signedThumbnailName")!;
        AssetName = info.GetString("_assetName")!;
        SignedAssetName = info.GetString("_signedAssetName")!;
        IsBgActive = info.GetInt32("_isBgActive");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_cardId", CardId);
        info.AddValue("_naviMoveX", NaviMoveX);
        info.AddValue("_naviMoveY", NaviMoveY);
        info.AddValue("_thumbnailName", ThumbnailName);
        info.AddValue("_signedThumbnailName", SignedThumbnailName);
        info.AddValue("_assetName", AssetName);
        info.AddValue("_signedAssetName", SignedAssetName);
        info.AddValue("_isBgActive", IsBgActive);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
